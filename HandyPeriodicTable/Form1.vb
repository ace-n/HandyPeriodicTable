Public Class Form1

    ' --- Data ---
    Dim Symbols As String() = {"h", "he", "li", "be", "b", "c", "n", "o", "f", "ne", "na", "mg", "al", "si", "p", "s", "cl", "ar", "k", "ca", "sc", "ti", "v", "cr", "mn", "fe", "co", "ni", "cu", "zn", "ga", "ge", "as", "se", "br", "kr", "rb", "sr", "y", "zr", "nb", "mo", "tc", "ru", "rh", "pd", "ag", "cd", "in", "sn", "sb", "te", "i", "xe", "cs", "ba", "la", "ce", "pr", "nd", "pm", "sm", "eu", "gd", "tb", "dy", "ho", "er", "tm", "yb", "lu", "hf", "ta", "w", "re", "os", "ir", "pt", "au", "hg", "tl", "pb", "bi", "po", "at", "rn", "fr", "ra", "ac", "th", "pa", "u", "np", "pu", "am", "cm", "bk", "cf", "es", "fm", "md", "no", "lr", "rf", "db", "sg", "bh", "hs", "mt", "ds", "rg", "cn", "uut", "uuq", "uup", "uuh", "uuo"}
    Dim Names As String() = {"hydrogen", "helium", "lithium", "beryllium", "boron", "carbon", "nitrogen", "oxygen", "fluorine", "neon", "sodium", "magnesium", "aluminium", "silicon", "phosphorus", "sulfur", "chlorine", "argon", "potassium", "calcium", "scandium", "titanium", "vanadium", "chromium", "manganese", "iron", "cobalt", "nickel", "copper", "zinc", "gallium", "germanium", "arsenic", "selenium", "bromine", "krypton", "rubidium", "strontium", "yttrium", "zirconium", "niobium", "molybdenum", "technetium", "ruthenium", "rhodium", "palladium", "silver", "cadmium", "indium", "tin", "antimony", "tellurium", "iodine", "xenon", "cesium", "barium", "lanthanum", "cerium", "praseodymium", "neodymium", "promethium", "samarium", "europium", "gadolinium", "terbium", "dysprosium", "holmium", "erbium", "thulium", "ytterbium", "lutetium", "hafnium", "tantalum", "tungsten", "rhenium", "osmium", "iridium", "platinum", "gold", "mercury", "thallium", "lead", "bismuth", "polonium", "astatine", "radon", "francium", "radium", "actinium", "thorium", "protactinium", "uranium", "neptunium", "plutonium", "americium", "curium", "berkelium", "californium", "einsteinium", "fermium", "mendelevium", "nobelium", "lawrencium", "rutherfordium", "dubnium", "seaborgium", "bohrium", "hassium", "meitnerium", "darmstadtium", "roentgenium", "copernicium", "ununtrium", "ununquadium", "ununpentium", "ununhexium", "ununoctium"}
    Dim AtomicMasses As String() = {"1.008", "4.0026", "6.94", "9.012", "10.81", "12.011", "14.007", "15.999", "18.998", "20.180", "22.990", "24.305", "26.982", "28.085", "30.973", "32.06", "35.45", "39.948", "39.0983", "40.078", "44.956", "47.867", "50.942", "51.996", "54.938", "55.845", "58.933", "58.693", "63.546", "65.38", "69.723", "72.63", "74.921", "78.96", "79.904", "83.798", "85.468", "87.62", "88.906", "91.224", "92.906", "95.96", "98", "101.07", "102.905", "106.42", "107.8682", "112.411", "114.818", "118.710", "121.760", "127.60", "126.904 47", "131.293", "132.905 4519", "137.327", "138.905", "140.116", "140.907", "144.242", "145", "150.36", "151.964", "157.25", "158.925 35", "162.500", "164.930 32", "167.259", "168.934 21", "173.054", "174.9668", "178.49", "180.947", "183.84", "186.207", "190.23", "192.217", "195.084", "196.966 569", "200.59", "204.384", "207.2", "208.980", "209", "210", "222", "223", "226", "227", "232.038", "231.036", "238.029", "237", "244", "243", "247", "247", "251", "252", "257", "258", "259", "262", "267", "268", "271", "272", "270", "276", "281", "280", "285", "284", "289", "288", "293", "294"}

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Initialization
        lblAtmMass.Text = ""
        lblAtmNum.Text = "No element found."
        lblName.Text = ""
        lblSymbol.Text = ""

    End Sub

    Private Sub ShowResults() Handles tbSrch.TextChanged

        ' -- Get element --
        Dim TBTxt As String = tbSrch.Text.ToLower
        Dim FinalIdx As Integer = -1

        ' Index search
        Dim Idx As Integer = -1

        Integer.TryParse(TBTxt, Idx)
        Idx -= 1

        If Idx < Symbols.Count AndAlso Idx > -1 Then
            FinalIdx = Idx
        End If

        ' Symbol search
        If FinalIdx = -1 Then
            FinalIdx = Array.IndexOf(Symbols, TBTxt)
        End If

        ' Name search
        If FinalIdx = -1 Then
            If TBTxt.Length > 2 Then
                For i = 0 To Names.Count - 1

                    If Names.GetValue(i).ToString.StartsWith(TBTxt) Then
                        FinalIdx = i
                        Exit For
                    End If

                Next
            End If
        End If

        ' Electron count
        Dim RowNum As Integer = 0
        Dim EsLeft As Integer = FinalIdx + 1
        Dim ELTotalFinal As Integer = 0 ' # of electron spaces in the current energy level

        For i = 1 To 7

            ' -- Get total for energy level --
            Dim ELTotal As Integer = 2 ' S

            ' P
            If i >= 2 Then
                ELTotal += 6
            End If
            ' D
            If i >= 4 Then
                ELTotal += 10
            End If

            ' F
            If i >= 6 Then
                ELTotal += 14
            End If

            ' Update final count of how many electrons are in the current energy level
            If EsLeft > 0 Then
                RowNum += 1
                ELTotalFinal = ELTotal
            End If

            ' Subtract from total electrons (if possible)
            If ELTotal <= EsLeft Then
                EsLeft -= ELTotal
            Else

                ' 0 valence electrons cannot exist - this means the valence shell is full
                If EsLeft = 0 Then
                    EsLeft = ELTotalFinal
                End If

                Exit For
            End If

        Next

        ' -- Report results --
        '   This assumes that the index is between -1 and (the maximum size of the list - 1) INCLUSIVE
        If FinalIdx <> -1 Then
            lblAtmMass.Text = AtomicMasses.GetValue(FinalIdx).ToString
            lblAtmNum.Text = (FinalIdx + 1).ToString
            lblName.Text = UpperFirst(Names.GetValue(FinalIdx))
            lblSymbol.Text = UpperFirst(Symbols.GetValue(FinalIdx))
            lblElectrons.Text = "Valence electrons: " & EsLeft.ToString & " (out of " & ELTotalFinal & ")"
            lblRowCol.Text = "Row " & RowNum.ToString & ", Column " & EsLeft.ToString
        Else
            lblAtmMass.Text = ""
            lblAtmNum.Text = "No element found."
            lblName.Text = ""
            lblSymbol.Text = ""
            lblElectrons.Text = ""
            lblRowCol.Text = ""
        End If

    End Sub

    Public Function UpperFirst(ByVal Str As String) As String
        Return Str.Chars(0).ToString.ToUpperInvariant & Str.Remove(0, 1)
    End Function

End Class
