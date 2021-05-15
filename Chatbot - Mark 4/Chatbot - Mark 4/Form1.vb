Public Class Form1

    'Commands

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "hello" Then
            Label1.Text = "Hi!"

        ElseIf TextBox1.Text = "open a website" Then
            Label1.Text = "Please enter the website name in the site opener"
            Panel1.Visible = True

        ElseIf TextBox1.Text = "open a site" Then
            Label1.Text = "Please enter the website name in the site opener"
            Panel1.Visible = True

        ElseIf TextBox1.Text = "open website" Then
            Label1.Text = "Please enter the website name in the site opener"
            Panel1.Visible = True

        ElseIf TextBox1.Text = "open sites" Then
            Label1.Text = "Please enter the website name in the site opener"
            Panel1.Visible = True

        ElseIf TextBox1.Text = "hi" Then
            Label1.Text = "Sup"

        ElseIf TextBox1.Text = "sup" Then
            Label1.Text = "Ello"

        ElseIf TextBox1.Text = "hey" Then
            Label1.Text = "Heyyyyyyyyyyyyyyyy"

        ElseIf TextBox1.Text = "Hola" Then
            Label1.Text = "Yo"

        ElseIf TextBox1.Text = "snake game" Then
            Label1.Text = "okay, have fun!"
            Panel3.Visible = True
            WebBrowser1.Navigate("https://playsnake.org/")

        ElseIf TextBox1.Text = "retro snake game" Then
            Label1.Text = "okay, have fun!"
            Panel3.Visible = True
            WebBrowser1.Navigate("https://playsnake.org/")

        ElseIf TextBox1.Text = "play snake game" Then
            Label1.Text = "okay, have fun!"
            Panel3.Visible = True
            WebBrowser1.Navigate("https://playsnake.org/")

        ElseIf TextBox1.Text = "search google" Then
            Label1.Text = "Please enter your search query in the Search bar."
            Panel2.Visible = True

        ElseIf TextBox1.Text = "google something" Then
            Label1.Text = "Please enter your search query in the Search bar."
            Panel2.Visible = True

        ElseIf TextBox1.Text = "google" Then
            Label1.Text = "Please enter your search query in the Search bar."
            Panel2.Visible = True

        ElseIf TextBox1.Text = "google search" Then
            Label1.Text = "Please enter your search query in the Search bar."
            Panel2.Visible = True

        ElseIf TextBox1.Text = "watch" Then
            Label1.Text = "Please enter the name of the video you would like to watch"
            Panel4.Visible = True

        ElseIf TextBox1.Text = "watch something" Then
            Label1.Text = "Please enter the name of the video you would like to watch"
            Panel4.Visible = True

        ElseIf TextBox1.Text = "entertainment" Then
            Label1.Text = "Please enter the name of the video you would like to watch"
            Panel4.Visible = True

        ElseIf TextBox1.Text = "watch vid" Then
            Label1.Text = "Please enter the name of the video you would like to watch"
            Panel4.Visible = True

        ElseIf TextBox1.Text = "watch videos" Then
            Label1.Text = "Please enter the name of the video you would like to watch"
            Panel4.Visible = True

        ElseIf TextBox1.Text = "watch a video" Then
            Label1.Text = "Please enter the name of the video you would like to watch"
            Panel4.Visible = True

        ElseIf TextBox1.Text = "youtube" Then
            Label1.Text = "Please enter the name of the video you would like to watch"
            Panel4.Visible = True

        ElseIf TextBox1.Text = "music" Then
            Panel5.Visible = True
            Label1.Text = "Please enter the name of the song you would like to listen to in the Music panel"

        ElseIf TextBox1.Text = "song" Then
            Panel5.Visible = True
            Label1.Text = "Please enter the name of the song you would like to listen to in the Music panel"

        ElseIf TextBox1.Text = "listen to music" Then
            Panel5.Visible = True
            Label1.Text = "Please enter the name of the song you would like to listen to in the Music panel"

        ElseIf TextBox1.Text = "listen to a song" Then
            Panel5.Visible = True
            Label1.Text = "Please enter the name of the song you would like to listen to in the Music panel"

        ElseIf TextBox1.Text = "how are you" Then
            Label1.Text = "I am fine, thankyou. How are you?"

        ElseIf TextBox1.Text = "how are you?" Then
            Label1.Text = "I am fine, thankyou. How are you?"

        ElseIf TextBox1.Text = "open minimap" Then
            WebBrowser1.Navigate("https://www.google.com/maps/")
            Panel3.Visible = True
            Label1.Text = "..."

        ElseIf TextBox1.Text = "minimap" Then
            WebBrowser1.Navigate("https://www.google.com/maps/")
            Panel3.Visible = True
            Label1.Text = "..."

        ElseIf TextBox1.Text = "find a place" Then
            Panel6.Visible = True
            Label1.Text = "Please enter the name of the place you would like to find in the find panel"

        ElseIf TextBox1.Text = "find location" Then
            Panel6.Visible = True
            Label1.Text = "Please enter the name of the place you would like to find in the find panel"

        ElseIf TextBox1.Text = "find a location" Then
            Panel6.Visible = True
            Label1.Text = "Please enter the name of the place you would like to find in the find panel"

        ElseIf TextBox1.Text = "find place" Then
            Panel6.Visible = True
            Label1.Text = "Please enter the name of the place you would like to find in the find panel"

        ElseIf TextBox1.Text = "who made you?" Then
            Label1.Text = "MST is the person who programmed me."

        ElseIf TextBox1.Text = "who made you" Then
            Label1.Text = "MST is the person who programmed me."

        ElseIf TextBox1.Text = "buy something" Then
            Label1.Text = "please enter the name of the product you would like to purchase in the textbox in the Panel named 'buy'"
            Panel7.Visible = True

        ElseIf TextBox1.Text = "buy" Then
            Label1.Text = "please enter the name of the product you would like to purchase in the textbox in the Panel named 'buy'"
            Panel7.Visible = True

        ElseIf TextBox1.Text = "purchase" Then
            Label1.Text = "please enter the name of the product you would like to purchase in the textbox in the Panel named 'buy'"
            Panel7.Visible = True

        ElseIf TextBox1.Text = "purchase something" Then
            Label1.Text = "please enter the name of the product you would like to purchase in the textbox in the Panel named 'buy'"
            Panel7.Visible = True

        ElseIf TextBox1.Text = "google shortcuts" Then
            Panel8.Visible = True
            Label1.Text = "Please press the button with the name of the Google sevice you would like to use"

        ElseIf TextBox1.Text = "gshortcuts" Then
            Panel8.Visible = True
            Label1.Text = "Please press the button with the name of the Google sevice you would like to use"

        ElseIf TextBox1.Text = "google services" Then
            Panel8.Visible = True
            Label1.Text = "Please press the button with the name of the Google sevice you would like to use"

        ElseIf TextBox1.Text = "gservices" Then
            Panel8.Visible = True
            Label1.Text = "Please press the button with the name of the Google service you would like to use"

        ElseIf TextBox1.Text = "bleh bleh bleh" Then
            Label1.Text = "Are you vampire?"

        ElseIf TextBox1.Text = "how are ya?" Then
            Label1.Text = "I'm good, you?"

        ElseIf TextBox1.Text = "how are ya" Then
            Label1.Text = "I'm good, you?"

        ElseIf TextBox1.Text = "i'm good" Then
            Label1.Text = "Glad to hear that"

        ElseIf TextBox1.Text = "im good" Then
            Label1.Text = "Good to hear that!"

        ElseIf TextBox1.Text = "date" Then
            Label1.Text = "The date today is " + Date.Now.ToString("dd-MMM-yyyy")

        ElseIf TextBox1.Text = "what is the date today?" Then
            Label1.Text = "The date today is " + Date.Now.ToString("dd-MMM-yyyy")

        ElseIf TextBox1.Text = "what's the date today?" Then
            Label1.Text = "The date today is " + Date.Now.ToString("dd-MMM-yyyy")

        ElseIf TextBox1.Text = "day" Then
            Label1.Text = "The day today is " + Date.Now.ToString("dddd")

        ElseIf TextBox1.Text = "day today" Then
            Label1.Text = "The day today is " + Date.Now.ToString("dddd")

        ElseIf TextBox1.Text = "what is the day today?" Then
            Label1.Text = "The day today is " + Date.Now.ToString("dddd")

        ElseIf TextBox1.Text = "what's the day today?" Then
            Label1.Text = "The day today is " + Date.Now.ToString("dddd")

        ElseIf TextBox1.Text = "month" Then
            Label1.Text = "It is the month of " + Date.Now.ToString("MMMM")

        ElseIf TextBox1.Text = "year" Then
            Label1.Text = "You are in the year " + Date.Now.ToString("yyyy")

        ElseIf TextBox1.Text = "What year is it?" Then
            Label1.Text = "You are in the year " + Date.Now.ToString("yyyy")

        ElseIf TextBox1.Text = "time" Then
            Label1.Text = "It is " + Date.Now.ToString("hh:mm")

        ElseIf TextBox1.Text = "what is the time" Then
            Label1.Text = "It is " + Date.Now.ToString("hh:mm")

        ElseIf TextBox1.Text = "please tell the time" Then
            Label1.Text = "It is " + Date.Now.ToString("hh:mm")

        ElseIf TextBox1.Text = "what's the time" Then
            Label1.Text = "It is " + Date.Now.ToString("hh:mm")

        ElseIf TextBox1.Text = "tell time" Then
            Label1.Text = "It is " + Date.Now.ToString("hh:mm")

        ElseIf TextBox1.Text = "tell the time" Then
            Label1.Text = "It is " + Date.Now.ToString("hh:mm")

        ElseIf TextBox1.Text = "tell the time please" Then
            Label1.Text = "It is " + Date.Now.ToString("hh:mm")

        ElseIf TextBox1.Text = "Close" Then
            Me.Close()

        ElseIf TextBox1.Text = "Bye" Then
            Me.Close()

        Else
            Label1.Text = "'" + TextBox1.Text + "'" + " " + "is not a valid command, please enter a different command."

        End If

        'speak function

        Dim SAPI As Object
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(Label1.Text)

    End Sub

    'Stuff to do when the form loads

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        Panel3.Visible = False
        Panel2.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
        Panel8.Visible = False
        Panel9.Visible = False
        Timer1.Enabled = True
    End Sub

    'Button Clck Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("www." + TextBox2.Text + ".com")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label1.Text = "..."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Visible = False
        Label1.Text = ""
        TextBox1.Text = "..."
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("http://www.google.com/search?q=" + TextBox3.Text)
        TextBox3.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel2.Visible = False
        TextBox1.Text = ""
        Label1.Text = "..."
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start("https://www.youtube.com/results?search_query=" + TextBox4.Text)
        TextBox4.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel4.Visible = False
        TextBox1.Text = ""
        Label1.Text = "..."
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click, Button24.Click
        Process.Start("https://music.youtube.com/search?q=" + TextBox5.Text)
        TextBox5.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button18.Click
        Panel5.Visible = False
        TextBox1.Text = ""
        Label1.Text = "..."
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then Button1_Click(sender, e)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Process.Start("https://www.google.com/maps/search/" + TextBox6.Text)
        TextBox6.Text = ""
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Panel6.Visible = False
        TextBox1.Text = ""
        Label1.Text = "..."
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then Button2_Click(sender, e)
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then Button6_Click(sender, e)
    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then Button8_Click(sender, e)
    End Sub

    Private Sub TextBox5_KeyDown(ByVal sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown, TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then Button10_Click(sender, e)
    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then Button12_Click(sender, e)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Process.Start("https://www.amazon.ae/s?k=" + TextBox7.Text)
        TextBox7.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel7.Visible = False
        TextBox1.Text = ""
        Label1.Text = "..."
    End Sub

    Private Sub TextBox7_KeyDown(ByVal sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then Button14_Click(sender, e)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Process.Start("https://translate.google.ae/")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Process.Start("https://meet.google.com/")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Process.Start("https://docs.google.com/document/u/0")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Process.Start("https://docs.google.com/presentation/u/0/")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Process.Start("https://docs.google.com/spreadsheets/u/0")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Process.Start("https://mail.google.com/mail/u/0/#inbox")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Process.Start("https://drive.google.com/drive/u/0/my-drive")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Process.Start("https://photos.google.com")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Panel8.Visible = False
    End Sub

    'Customization

    Private Sub FontsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontsToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label1.Font = FontDialog1.Font
            Label2.Font = FontDialog1.Font
            Label3.Font = FontDialog1.Font
            Label4.Font = FontDialog1.Font
            Label5.Font = FontDialog1.Font
            Label6.Font = FontDialog1.Font
            Label7.Font = FontDialog1.Font
            Button1.Font = FontDialog1.Font
            Button2.Font = FontDialog1.Font
            Button3.Font = FontDialog1.Font
            Button4.Font = FontDialog1.Font
            Button5.Font = FontDialog1.Font
            Button6.Font = FontDialog1.Font
            Button7.Font = FontDialog1.Font
            Button8.Font = FontDialog1.Font
            Button9.Font = FontDialog1.Font
            Button10.Font = FontDialog1.Font
            Button11.Font = FontDialog1.Font
            Button12.Font = FontDialog1.Font
            Button13.Font = FontDialog1.Font
            Button14.Font = FontDialog1.Font
            Button15.Font = FontDialog1.Font
            Button16.Font = FontDialog1.Font
            Button17.Font = FontDialog1.Font
            Button18.Font = FontDialog1.Font
            Button19.Font = FontDialog1.Font
            Button20.Font = FontDialog1.Font
            Button21.Font = FontDialog1.Font
            Button22.Font = FontDialog1.Font
            Button23.Font = FontDialog1.Font
            Button24.Font = FontDialog1.Font
            Button25.Font = FontDialog1.Font
            TextBox1.Font = FontDialog1.Font
            TextBox2.Font = FontDialog1.Font
            TextBox3.Font = FontDialog1.Font
            TextBox4.Font = FontDialog1.Font
            TextBox5.Font = FontDialog1.Font
            TextBox6.Font = FontDialog1.Font
            TextBox7.Font = FontDialog1.Font
            TextBox8.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If

        If Me.BackColor = Color.White Then
            Label1.ForeColor = Color.Black
            Panel1.BackColor = Color.Gray
            Panel2.BackColor = Color.Gray
            Panel3.BackColor = Color.Gray
            Panel4.BackColor = Color.Gray
            Panel5.BackColor = Color.Gray
            Panel6.BackColor = Color.Gray
            Panel7.BackColor = Color.Gray
            Panel8.BackColor = Color.Gray
            Panel9.BackColor = Color.Gray

        Else
            Label1.ForeColor = Color.White
            Panel1.BackColor = Color.White
            Panel2.BackColor = Color.White
            Panel3.BackColor = Color.White
            Panel4.BackColor = Color.White
            Panel5.BackColor = Color.White
            Panel6.BackColor = Color.White
            Panel7.BackColor = Color.White
            Panel8.BackColor = Color.White
            Panel9.BackColor = Color.White
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("DomeBot  was made by MST_CREATOR", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub CommandsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

End Class