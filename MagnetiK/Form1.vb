Public Class Form1
    Dim URL As String
    Dim Trackerlist As String = "&tr=udp%3A%2F%2Ftracker.openbittorrent.com%3A80&tr=http://inferno.demonoid.me:3407/announce%3A80&tr=udp://tracker.openbittorrent.com:80/announce%3A80&tr=http://tracker.openbittorrent.com/announce%3A80&tr=udp://tracker.publicbt.com:80/announce%3A80&tr=http://tracker.publicbt.com:80/announce%3A80&tr=udp%3A%2F%2Fopentor.org%3A2710&tr=udp%3A%2F%2Ftracker.ccc.de%3A80&tr=udp%3A%2F%2Ftracker.blackunicorn.xyz%3A6969&tr=udp%3A%2F%2Ftracker.coppersurfer.tk%3A6969&tr=udp%3A%2F%2Ftracker.leechers-paradise.org%3A6969"
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Process.Start(URL)
        Catch ex As Exception
            MessageBox.Show("There is no program installed to handle Magnet links")
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        URL = "magnet:?xt=urn:btih:" & TextBox1.Text & "&dn=" & TextBox2.Text & Trackerlist
        Clipboard.Clear()
        Clipboard.SetText(URL)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LinkLabel1.Enabled = True
        LinkLabel2.Enabled = True
        URL = "magnet:?xt=urn:btih:" & TextBox1.Text & "&dn=" & TextBox2.Text & Trackerlist
    End Sub
End Class
