Imports System.Security.Cryptography
Public Class autologinmicrosoft


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            My.Settings.ALmicrosoftENA = True
        Else
            My.Settings.ALmicrosoftENA = False
        End If
        My.Settings.ALmicrosoftUN = TextBox1.Text
        My.Settings.Save()
        TestEncoding()
        MsgBox("You need to restart MySurf in order for the encryption to finish.")
    End Sub
    Dim appPath As String = Application.StartupPath
    Sub TestEncoding()
        Dim plainText As String
        Dim password As String
        plainText = TextBox2.Text
        password = ("EnterYourPasswordHere")

        Dim wrapper As New Simple3DesMicro(password)
        Dim cipherText As String = wrapper.EncryptData(plainText)
        MsgBox(cipherText)
        My.Settings.ALmicrosoftENC = cipherText
    End Sub
    Sub TestDecoding()
        Dim cipherText As String = My.Settings.ALmicrosoftENC
        Dim password As String = ("EnterYourPasswordHere")
        Dim wrapper As New Simple3DesMicro(password)

        ' DecryptData throws if the wrong password is used. 
        Try
            Dim plainText As String = wrapper.DecryptData(cipherText)
            'Stores decrypted password in My.Settings for faster access. The decrypted password will be deleted when the application is closed.
            My.Settings.ALmicrosoftPASS = plainText
        Catch ex As System.Security.Cryptography.CryptographicException
            If My.Settings.ALmicrosoftENA = True Then
                MsgBox("Sorry, MySurf AutoLogin is not available. Please re-enter your account password in settings.")
            Else

            End If
        End Try
    End Sub
    Private Sub autologinmicrosoft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ALmicrosoftENA = True Then
            CheckBox1.Checked = True
            TextBox1.Text = My.Settings.ALmicrosoftUN
        End If
    End Sub
End Class
Public NotInheritable Class Simple3DesMicro
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private Function TruncateHash(
    ByVal key As String,
    ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key. 
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash. 
        ReDim Preserve hash(length - 1)
        Return hash
    End Function
    Sub New(ByVal key As String)
        ' Initialize the crypto provider.
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub
    Public Function EncryptData(
    ByVal plaintext As String) As String

        ' Convert the plaintext string to a byte array. 
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream. 
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream. 
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string. 
        Return Convert.ToBase64String(ms.ToArray)
    End Function
    Public Function DecryptData(
    ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array. 
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream. 
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream. 
        Dim decStream As New CryptoStream(ms,
            TripleDes.CreateDecryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string. 
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Class