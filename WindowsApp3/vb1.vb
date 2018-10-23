Public Class Form1

    Dim provinsinya As String

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub kodekereta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kodekereta.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles nik.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim harganya, hargaeuy As Integer
        Dim jenisnya, jamnya As String

        Select Case kodekereta.Text
            Case "KA-PRH"
                hargaeuy = 120000
                jenisnya = "Eksekutif"
                jamnya = "08.00"
            Case "KA-BMA"
                hargaeuy = 80000
                jenisnya = "Bisnis"
                jamnya = "09.00"
            Case "KA-EKO"
                hargaeuy = 50000
                jenisnya = "Ekonomi"
                jamnya = "10.00"
        End Select

        harga.Text = hargaeuy.ToString
        jenis.Text = jenisnya.ToString
        berangkat.Text = jamnya.ToString
        total.Text = "Rp. " + harganya.ToString

    End Sub

    Private Sub provinsi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles provinsi.SelectedIndexChanged
        Select Case provinsi.Text
            Case "Jawa Barat"
                kota.Text = ""
                kota.Items.Clear()
                kota.Items.Add("Bandung")
                kota.Items.Add("Cimahi")
            Case "Jawa Tengah"
                kota.Text = ""
                kota.Items.Clear()
                kota.Items.Add("Brebes")
                kota.Items.Add("Jogjakarta")
            Case "Jawa Timur"
                kota.Text = ""
                kota.Items.Clear()
                kota.Items.Add("Surabaya")
                kota.Items.Add("Malang")
            Case "DKI Jakarta"
                kota.Text = ""
                kota.Items.Clear()
                kota.Items.Add("Jakarta Selatan")
                kota.Items.Add("Jakarta Utara")
        End Select
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles save.Click
        MessageBox.Show(nama.Text & vbCrLf & nik.Text & vbCrLf & alamat.Text & vbCrLf & provinsi.Text & vbCrLf & kota.Text & vbCrLf & kecamatan.Text & vbCrLf & kodepos.Text & vbCrLf & tanggal.Text & vbCrLf & kodekereta.Text & vbCrLf & harga.Text & vbCrLf & jenis.Text & vbCrLf & total.Text,
                        "Info Tiket", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub bersih_Click(sender As Object, e As EventArgs) Handles bersih.Click
        nama.Text = ""
        nik.Text = ""
        alamat.Text = ""
        provinsi.Text = ""
        kota.Text = ""
        kecamatan.Text = ""
        kodepos.Text = ""
        tanggal.Text = ""
        kodekereta.Text = ""
        harga.Text = ""
        jenis.Text = ""
        berangkat.Text = ""
        tiket.Text = ""
        total.Text = ""
        kota.Items.Clear()
        kecamatan.Items.Clear()
    End Sub

    Private Sub kecamatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kecamatan.SelectedIndexChanged

    End Sub

    Private Sub kota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kota.SelectedIndexChanged
        Select Case kota.Text
            Case "Cimahi"
                kecamatan.Text = ""
                kecamatan.Items.Clear()
                kecamatan.Items.Add("Cimahi Utara")
                kecamatan.Items.Add("Cimahi Selatan")
            Case "Bandung"
                kecamatan.Text = ""
                kecamatan.Items.Clear()
                kecamatan.Items.Add("Bandung Utara")
                kecamatan.Items.Add("Bandung Selatan")
            Case "Brebes"
                kecamatan.Text = ""
                kecamatan.Items.Clear()
                kecamatan.Items.Add("Brebes Utara")
                kecamatan.Items.Add("Brebes Selatan")
            Case "Jogjakarta"
                kecamatan.Text = ""
                kecamatan.Items.Clear()
                kecamatan.Items.Add("Jogjakarta Utara")
                kecamatan.Items.Add("Jogjakarta Selatan")
            Case "Surabaya"
                kecamatan.Text = ""
                kecamatan.Items.Clear()
                kecamatan.Items.Add("Surabaya Utara")
                kecamatan.Items.Add("Surabaya Selatan")
            Case "Malang"
                kecamatan.Text = ""
                kecamatan.Items.Clear()
                kecamatan.Items.Add("Malang Utara")
                kecamatan.Items.Add("Malang Selatan")
            Case "Jakarta Selatan"
                kecamatan.Text = ""
                kecamatan.Items.Clear()
                kecamatan.Items.Add("Menteng")
                kecamatan.Items.Add("Blok M")
            Case "Jakarta Utara"
                kecamatan.Text = ""
                kecamatan.Items.Clear()
                kecamatan.Items.Add("Condet")
                kecamatan.Items.Add("Kelapa Gading")
        End Select
    End Sub

    Private Sub nama_TextChanged(sender As Object, e As EventArgs) Handles nama.TextChanged

    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tiket_TextChanged(sender As Object, e As EventArgs) Handles tiket.TextChanged

    End Sub

    Public Sub tiket_OnChange(sender As Object, e As EventArgs) Handles tiket.TextChanged
        Dim tot As Integer
        tot = Val(tiket.Text) * Val(harga.Text)
        total.Text = "Rp. " + tot.ToString
    End Sub
End Class
