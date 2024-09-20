Imports MySql.Data.MySqlClient ' Importa la llibreria del client MySQL

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cadena de connexió per a la base de dades MySQL
        Dim connectionString As String = "Server=sql.freedb.tech;Port=3306;Database=freedb_SimpaBankDB;Uid=freedb_alonso;Pwd=BtuQv7ft?9fqBT8;"

        ' Crea un objecte MySqlConnection per connectar-se a la base de dades MySQL
        Dim conn As New MySqlConnection(connectionString)


        Try
            ' Prova a obrir la connexió
            conn.Open()
            ' Si la connexió s'obre sense problemes, mostra un missatge
            MessageBox.Show("Connexió a la base de dades exitosa!", "Connexió Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Si hi ha algun error en la connexió, mostra un missatge d'error
            MessageBox.Show("Error en la connexió a la base de dades: " & ex.Message, "Error de Connexió", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tanca la connexió quan hagis acabat
            conn.Close()
        End Try

        ' Has inicialitzat l'objecte de connexió, però encara no has obert la connexió.
        ' Podries obrir la connexió en aquest punt si necessites interactuar amb la base de dades.
        ' conn.Open()
    End Sub

    Private Sub Sortir_Click(sender As Object, e As EventArgs) Handles Sortir.Click
        ' Aquest controlador d'events és per a un esdeveniment de clic de botó, però actualment està buit.
        ' Pots afegir codi aquí per realitzar accions quan es faci clic al botó.
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Aquest controlador d'events és per a un esdeveniment de clic de PictureBox, però actualment està buit.
        ' Pots afegir codi aquí per realitzar accions quan es faci clic al PictureBox.
    End Sub

    Private Sub Accedir_Click(sender As Object, e As EventArgs) Handles Accedir.Click

    End Sub
End Class
