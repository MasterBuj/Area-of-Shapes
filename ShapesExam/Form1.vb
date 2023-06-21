
Public Class Form1

    Private Sub IsInt(sender As Object, e As EventArgs) Handles TextBox9.TextChanged, TextBox8.TextChanged, TextBox7.TextChanged, TextBox6.TextChanged, TextBox5.TextChanged, TextBox4.TextChanged, TextBox3.TextChanged, TextBox2.TextChanged, TextBox17.TextChanged, TextBox14.TextChanged, TextBox13.TextChanged, TextBox12.TextChanged, TextBox11.TextChanged, TextBox10.TextChanged, TextBox1.TextChanged, TextBox15.TextChanged, TextBox16.TextChanged

        If IsNumeric(sender.Text) Then
            'Rectangle
            If TextBox1.Text IsNot "" And TextBox2.Text IsNot "" Then
                recA.Text = TextBox1.Text * TextBox2.Text
                recP.Text = (2 * TextBox1.Text) + (2 * TextBox2.Text)
            End If

            'Parallelogram
            If TextBox3.Text IsNot "" And TextBox4.Text IsNot "" Then
                parA.Text = TextBox3.Text * TextBox4.Text
                parP.Text = (2 * TextBox3.Text) + (2 * TextBox4.Text)
            End If

            'Rectangular
            If TextBox5.Text IsNot "" And TextBox6.Text IsNot "" And TextBox7.Text IsNot "" Then
                rectV.Text = TextBox5.Text * TextBox6.Text * TextBox7.Text
                rectS.Text = (2 * TextBox5.Text * TextBox6.Text) + (2 * TextBox5.Text * TextBox7.Text) + (2 * TextBox6.Text * TextBox7.Text)
            End If

            'Triangle
            If TextBox8.Text IsNot "" And TextBox10.Text IsNot "" Then
                triA.Text = (TextBox8.Text * TextBox10.Text) / 2
                If TextBox9.Text IsNot "" Then
                    triP.Text = CInt(TextBox8.Text) + CInt(TextBox9.Text) + CInt(TextBox10.Text)
                End If
            End If

            'Trapezoid 
            If TextBox11.Text IsNot "" And TextBox12.Text IsNot "" Then
                If TextBox13.Text IsNot "" Then
                    trapA.Text = ((CInt(TextBox11.Text) + CInt(TextBox12.Text)) / 2) * TextBox13.Text
                End If
                If TextBox14.Text IsNot "" And TextBox15.Text IsNot "" Then
                    trapP.Text = CInt(TextBox11.Text) + CInt(TextBox12.Text) + CInt(TextBox14.Text) + CInt(TextBox15.Text)
                End If
            End If

            'Circle
            If TextBox17.Text IsNot "" Then
                Dim R As Double
                R = TextBox17.Text
                cirD.Text = 2 * R
                cirC.Text = Decimal.Round(2 * 3.14 * R, 4, MidpointRounding.AwayFromZero)
                cirA.Text = 3.14 * (R * R)
            End If
            If TextBox16.Text IsNot "" Then
                cirR.Text = Decimal.Round(TextBox16.Text / (2 * 3.14), 4, MidpointRounding.AwayFromZero)
            End If

        End If

    End Sub

End Class
