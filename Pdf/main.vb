Imports FastColoredTextBoxNS
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class main

    Dim n As New FastColoredTextBoxNS.FastColoredTextBox
    Dim PdfDoc As New Document()


    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebBrowser1.ScriptErrorsSuppressed = True
        'notepade
        n.Text = My.Resources._default
        n.Dock = DockStyle.Fill : n.Language = FastColoredTextBoxNS.Language.HTML

        RichTextBox1.Controls.Add(n)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If n.Language = Language.HTML Then
            n.Visible = False
            WebBrowser1.Visible = True
            WebBrowser1.DocumentText = n.Text
        Else
            MsgBox("html المرجو تغير الصيغة الى")
        End If
    End Sub



    Private Sub PHPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PHPToolStripMenuItem.Click
        n.Text = My.Resources.php
        CType(Me.RichTextBox1.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = Language.PHP
        My.Computer.Audio.Play(My.Resources.Cocking, AudioPlayMode.Background)
    End Sub

    Private Sub VBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VBToolStripMenuItem.Click
        n.Text = My.Resources.vb
        CType(Me.RichTextBox1.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = Language.VB
        My.Computer.Audio.Play(My.Resources.Cocking, AudioPlayMode.Background)
    End Sub

    Private Sub CSharpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CSharpToolStripMenuItem.Click
        n.Text = My.Resources.sharp
        CType(Me.RichTextBox1.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = Language.CSharp
        My.Computer.Audio.Play(My.Resources.Cocking, AudioPlayMode.Background)
    End Sub

    Private Sub JSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JSToolStripMenuItem.Click
        n.Text = My.Resources.js
        CType(Me.RichTextBox1.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = Language.JS
        My.Computer.Audio.Play(My.Resources.Cocking, AudioPlayMode.Background)
    End Sub

    Private Sub LUAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LUAToolStripMenuItem.Click
        n.Text = My.Resources.lua
        CType(Me.RichTextBox1.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = Language.Lua
        My.Computer.Audio.Play(My.Resources.Cocking, AudioPlayMode.Background)
    End Sub

    Private Sub SQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SQLToolStripMenuItem.Click
        n.Text = My.Resources.sql
        CType(Me.RichTextBox1.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = Language.SQL
        My.Computer.Audio.Play(My.Resources.Cocking, AudioPlayMode.Background)
    End Sub

    Private Sub XMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XMLToolStripMenuItem.Click
        n.Text = My.Resources.xml
        CType(Me.RichTextBox1.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = Language.XML
        My.Computer.Audio.Play(My.Resources.Cocking, AudioPlayMode.Background)
    End Sub

    Private Sub NormalTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalTextToolStripMenuItem.Click
        n.Text = My.Resources._default
        CType(Me.RichTextBox1.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = Language.Custom
        My.Computer.Audio.Play(My.Resources.Cocking, AudioPlayMode.Background)
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click

        If n.Language = Language.Custom Then
            Dim PdtWrite As PdfWriter = PdfWriter.GetInstance(PdfDoc, New FileStream("Default.pdf", FileMode.Create))
            PdfDoc.Open()
            PdfDoc.Add(New Paragraph(n.Text))
            PdfDoc.NewPage()
            PdfDoc.Close()
            MsgBox("تمت اضافة الملف بنجاح")
        Else
            MsgBox(" custum المرجو اختيار اللغة ")
        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.DefaultExt = "*.pdf"
        SaveFileDialog1.Filter = "PDF FILES|*.pdf"
        SaveFileDialog1.CreatePrompt = True
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If

    End Sub

    Private Sub OpenFilleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFilleToolStripMenuItem.Click
        OpenFileDialog1.DefaultExt = "*.Html"
        OpenFileDialog1.Filter = "PDF FILES|*.html"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            n.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        MsgBox("لقد تم حفظ النموذج")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub HtmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HtmlToolStripMenuItem.Click
        n.Text = My.Resources.html
        CType(Me.RichTextBox1.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = Language.HTML
        My.Computer.Audio.Play(My.Resources.Cocking, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        n.Visible = True
        WebBrowser1.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class

