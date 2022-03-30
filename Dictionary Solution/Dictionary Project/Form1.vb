Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

'v1.02 Changes: 
'---------------------------------
'File > Open now opens file explorer!
'Functions added to consolidate redundant code. See populateKeyList and populateValueList below.
'Added totalGames variable and function. Now, users can see the total size of their game collection.
'Add button now selected by default, making adding games much easier.
'Console and Game text fields are now the only tabbable elements. Also makes adding games easier.
'At least one game (index 0) will be selected at all times when the games list is populated

'Upcoming:
'---------------------------------
'TODO: Styling. Incorporate some image element indicating known consoles when selected. Background changes to xbox when xbox input and selected for instance.
'TODO: Add timer for file opened confirmation green text so it goes away on its own after a few seconds.
'TODO: Configure sort games functionality.
'TODO: Implement time and date game added.
'TODO: Save file as any name and location user desires. Multiple lists on one device.
'TODO (stretch): Serialization switch to JSON format as to take advantage of object notation.
'TODO (super stretch): Implement API call to get game covers.

Public Class Form1
    Dim gameDictionary As New GamesCollection
    Dim totalGames As Integer
    Dim timer As Timer = New Timer()

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If Not gameDictionary.belongsTo.ContainsKey(txtKeyEntry.Text) Then
                lstKeys.Items.Clear()
                lstValues.Items.Clear()

                gameDictionary.belongsTo.Add(txtKeyEntry.Text.ToString, New List(Of String))
                gameDictionary.belongsTo(txtKeyEntry.Text).Add(txtValueEntry.Text)

                populateKeyList(gameDictionary.belongsTo)
                populateValueList(gameDictionary.belongsTo)
                updateTotalGames(gameDictionary.belongsTo)

                If lstKeys.Items.Contains(txtKeyEntry.Text) Then
                    Dim currentItem As String = -1
                    For index As Integer = 0 To lstKeys.Items.Count - 1
                        If lstKeys.GetItemText(lstKeys.Items(index)).Equals(txtKeyEntry.Text) Then
                            currentItem = index
                        End If
                    Next
                    lstKeys.SelectedItem = lstKeys.Items(currentItem)
                End If
            Else
                lstKeys.Items.Clear()
                lstValues.Items.Clear()

                gameDictionary.belongsTo(txtKeyEntry.Text).Add(txtValueEntry.Text.ToString)

                populateKeyList(gameDictionary.belongsTo)
                populateValueList(gameDictionary.belongsTo)
                updateTotalGames(gameDictionary.belongsTo)

                If lstKeys.Items.Contains(txtKeyEntry.Text) Then
                    Dim currentItem As String = -1
                    For index As Integer = 0 To lstKeys.Items.Count - 1
                        If lstKeys.GetItemText(lstKeys.Items(index)).Equals(txtKeyEntry.Text) Then
                            currentItem = index
                        End If
                    Next
                    lstKeys.SelectedItem = lstKeys.Items(currentItem)
                End If
            End If

        Catch invalidFormat As InvalidOperationException
            MessageBox.Show(invalidFormat.Message, "")
        End Try
    End Sub

    Private Sub lstKeys_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstKeys.SelectedIndexChanged
        Try
            lstValues.Items.Clear()
            populateValueList(gameDictionary.belongsTo)
            If Not lstValues.Items.Count.Equals(0) Then
                lstValues.SelectedItem = lstValues.Items(0)
            End If

        Catch outOfRange As IndexOutOfRangeException
            Console.WriteLine("Tried to operate out of list range again.")
        End Try

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemoveKey.Click
        Try
            If gameDictionary.belongsTo.ContainsKey(lstKeys.GetItemText(lstKeys.SelectedItem).ToString) Then
                gameDictionary.belongsTo.Remove(lstKeys.GetItemText(lstKeys.SelectedItem).ToString)

                lstKeys.Items.Clear()
                lstValues.Items.Clear()

                populateKeyList(gameDictionary.belongsTo)
                populateValueList(gameDictionary.belongsTo)
                updateTotalGames(gameDictionary.belongsTo)
            End If
        Catch ex As KeyNotFoundException

        End Try
    End Sub

    Private Sub btnRemoveVal_Click(sender As Object, e As EventArgs) Handles btnRemoveVal.Click
        Try
            Dim newList As New List(Of String)
            If gameDictionary.belongsTo.ContainsKey(lstKeys.GetItemText(lstKeys.SelectedItem).ToString) Then
                lstValues.Items.RemoveAt(lstValues.SelectedIndex())

                For Each newItem In lstValues.Items
                    newList.Add(newItem)
                Next

                gameDictionary.belongsTo.Remove(lstKeys.GetItemText(lstKeys.SelectedItem).ToString)
                gameDictionary.belongsTo.Add(lstKeys.GetItemText(lstKeys.SelectedItem).ToString, newList)

                lstValues.Items.Clear()

                populateValueList(gameDictionary.belongsTo)
                updateTotalGames(gameDictionary.belongsTo)

                lstValues.SelectedItem = lstValues.Items(0)
            End If
        Catch ex As ArgumentOutOfRangeException
            Console.WriteLine("Tried to operate out of list range again.")
        End Try
    End Sub

    'Saves serialized binary file to bin/debug
    Private Sub CreateFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateFileToolStripMenuItem.Click
        Using fs As New FileStream("GameCollection", FileMode.Create)
            Dim formatter As New BinaryFormatter()
            formatter.Serialize(fs, gameDictionary)
        End Using
    End Sub

    'Opens file dialogue box instructions - Find the .File file that was saved to bin/debug within the project hierchy!
    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        lstKeys.Items.Clear()
        lstValues.Items.Clear()

        fdOpen.InitialDirectory = "C:\"
        fdOpen.Title = "Open a File"
        fdOpen.ShowDialog()

        Dim fileName As String = fdOpen.FileName

        If fileName.Contains("GameCollection") Then
            Using fs As New FileStream(fileName, FileMode.Open)
                Dim formatter As New BinaryFormatter()
                gameDictionary = formatter.Deserialize(fs)
            End Using

            populateKeyList(gameDictionary.belongsTo)
        End If
        updateTotalGames(gameDictionary.belongsTo)
        lblTotalGames.Text = "Total Games: " & totalGames.ToString()

    End Sub

    'Sorting consoles instruction via sort consoles button under tools
    Private Sub SortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortToolStripMenuItem.Click
        lstKeys.Items.Clear()
        gameDictionary.belongsTo = gameDictionary.belongsTo.OrderBy(Function(x) x.Key).ToDictionary(Function(x) x.Key, Function(x) x.Value)
        For Each item As KeyValuePair(Of String, List(Of String)) In gameDictionary.belongsTo
            lstKeys.Items.Add(item.Key)
        Next
    End Sub

    'Exit application via exit button under file
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Functions defined to populate Keys and Values respectively for more concise code.
    Public Function populateKeyList(dict As Dictionary(Of String, List(Of String)))
        For Each item As KeyValuePair(Of String, List(Of String)) In dict
            lstKeys.Items.Add(item.Key)
        Next
    End Function

    Public Function populateValueList(dict As Dictionary(Of String, List(Of String)))
        For Each item As KeyValuePair(Of String, List(Of String)) In dict
            If item.Key.ToString.Equals(lstKeys.GetItemText(lstKeys.SelectedItem).ToString) Then
                For Each game As String In item.Value
                    lstValues.Items.Add(game)
                Next
            End If
        Next
    End Function

    Function updateTotalGames(dict As Dictionary(Of String, List(Of String)))
        totalGames = 0
        For Each item As KeyValuePair(Of String, List(Of String)) In dict
            For Each game As String In item.Value
                totalGames += 1
            Next
        Next
        lblTotalGames.Text = "Total Games: " & totalGames.ToString()
    End Function

    <Serializable>
    Public Class GamesCollection
        Public Property belongsTo As New Dictionary(Of String, List(Of String))
    End Class
End Class
