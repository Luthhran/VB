Public Class form1



    Private Sub CMDCorrect_Click(sender As System.Object, e As System.EventArgs) Handles CMDCorrect.Click
        If Txt1.Text = "1" And Txt2.Text = "0" And Txt3.Text = "1" And Txt4.Text = "1" And Txt5.Text = "0" And Txt6.Text = "1" And Txt7.Text = "0" And Txt8.Text = "1" And Txt9.Text = "0" And Txt10.Text = "0" And Txt11.Text = "0" And Txt12.Text = "1" And Txt13.Text = "0" And Txt14.Text = "0" And Txt15.Text = "1" And Txt16.Text = "1" And Txt17.Text = "0" And Txt18.Text = "0" And Txt19.Text = "1" And Txt20.Text = "1" And Txt21.Text = "0" And Txt22.Text = "0" And Txt23.Text = "1" And Txt24.Text = "1" And Txt25.Text = "0" And Txt26.Text = "0" And Txt27.Text = "1" And Txt28.Text = "0" And Txt29.Text = "1" And Txt30.Text = "1" And Txt31.Text = "1" And Txt32.Text = "1" And Txt33.Text = "0" And Txt34.Text = "0" And Txt35.Text = "1" And Txt36.Text = "0" And Txt37.Text = "1" And Txt38.Text = "1" And Txt39.Text = "0" And Txt40.Text = "0" And Txt41.Text = "1" And Txt42.Text = "0" And Txt43.Text = "0" And Txt44.Text = "1" And Txt45.Text = "0" And Txt46.Text = "1" And Txt47.Text = "0" And Txt48.Text = "0" And Txt49.Text = "1" And Txt50.Text = "1" And Txt51.Text = "0" And Txt52.Text = "1" And Txt53.Text = "1" And Txt54.Text = "0" And Txt55.Text = "1" And Txt56.Text = "0" And Txt57.Text = "1" And Txt58.Text = "1" And Txt59.Text = "0" And Txt60.Text = "0" And Txt61.Text = "1" And Txt62.Text = "0" And Txt63.Text = "1" And Txt64.Text = "0" And Txt65.Text = "1" And Txt66.Text = "1" And Txt67.Text = "0" And Txt68.Text = "1" And Txt69.Text = "0" And TxT70.Text = "0" And Txt71.Text = "0" And Txt72.Text = "1" And Txt73.Text = "0" And Txt74.Text = "1" And Txt75.Text = "0" And Txt76.Text = "0" And Txt77.Text = "1" And Txt78.Text = "0" And Txt79.Text = "1" And Txt80.Text = "1" And Txt81.Text = "0" And Txt82.Text = "0" And Txt83.Text = "1" And Txt84.Text = "1" And Txt85.Text = "0" And Txt86.Text = "1" And Txt87.Text = "1" And Txt88.Text = "0" And Txt89.Text = "0" And Txt90.Text = "1" And Txt91.Text = "1" And Txt92.Text = "1" And Txt93.Text = "0" And Txt94.Text = "0" And Txt95.Text = "1" And Txt96.Text = "0" And Txt97.Text = "0" And Txt98.Text = "1" And Txt99.Text = "1" And Txt100.Text = "0" Then
            MsgBox("Bravo")
        Else : MsgBox("Tu as fait une erreur. Recommence")

        End If
    End Sub

    Private Sub CMDend_Click(sender As System.Object, e As System.EventArgs) Handles CMDend.Click
        End
    End Sub

    Private Sub CmdReset_Click(sender As System.Object, e As System.EventArgs) Handles CmdReset.Click
        Application.Restart()
    End Sub
End Class
