Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sal As Double
        Dim hse As Double
        Dim con As Double
        Dim med As Double
        Dim trans As Double
        Dim util As Double
        Dim bonus As Double
        Dim gross As Double
        Dim net As Double
        Dim tax As Double

        sal = Convert.ToDecimal(txtBasic.Text)
        If CheckBox1.Checked = True Then
            hse = (35 / 100) * sal
        End If

        If CheckBox3.Checked = True Then
            con = (8 / 100) * sal
        End If

        If CheckBox5.Checked = True Then
            trans = (9 / 100) * sal
        End If

        If CheckBox2.Checked = True Then
            med = (7 / 100) * sal
        End If

        If CheckBox6.Checked = True Then
            util = (12 / 100) * sal
        End If

        If CheckBox4.Checked = True Then
            If cmbBenefits.Text = "New Year Bonus" Then
                bonus = 3500
            End If
            If cmbBenefits.Text = "Diwali Bonus" Then
                bonus = 5000
            End If
            If cmbBenefits.Text = "Weekend Bonus" Then
                bonus = (1 / 100) * sal
            End If
            If cmbBenefits.Text = "Overtime Bonus" Then
                bonus = 6500
            End If

        End If
        gross = bonus + hse + con + med + trans + util + sal
        tax = (15 / 100) * sal
        net = gross - tax
        TextBox3.Text = Convert.ToDouble(gross)
        TextBox4.Text = Convert.ToDouble(net)
        TextBox1.Text = Convert.ToDouble(tax)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        cmbBenefits.Text = ""
        cmbDesig.Text = ""
        txtBasic.Clear()
        txtName.Clear()
    End Sub
End Class
