Public Class Compilador
    Dim Cr(50000) As String 'matriz de carácteres
    Dim PrMtx(2000) As String 'matriz de palabras reservadas
    Dim Pr(,) As String = {{"Proceder", "I"}, {"FinProceder", "F"}, {"Repetir", "I"}, {"FinRepetir", "F"}, {"Romper", "F"}, {"Sielvalor", "I"}, {"Ejecutar", "P"}, {"FinEjecutar", "P"}, {"Procedimiento", "I"}, {"FinProcedimiento", "F"}, {"entero", "I"}, {"caracter", "I"}, {"decimal", "I"}, {"Imprimir", "I"}}
    'son las palabras reservadas

    Dim Conector As String
    Dim Variable As String
    Dim Valor As String
    Dim Palabra As String
    Dim Cont_PR As Integer = 1 'contador de palabras reservadas
    Dim Cont_SENT As Integer = 1 'contador de sentencias
    Dim Cont_INS As Integer = 1  'CONTADOR INStrucciones
    Dim Cont_ALFA As Integer = 0  'contador alfanuméricos.
    Dim Cont_VAR As Integer = 0  'contador variables
    Dim Cont_CN As Integer = 1  ' contador de conectores
    Dim Compilacion As Integer
    Dim Var_Existe As Boolean
    Dim Tipo_Var As String
    Dim Variable_Declarada As Boolean
    Dim ANSIN_Sent As Integer = 1 'análisis sintactico empezamos en la sentencia 1
    Dim SN_fin = False
    Dim SN_cont As Integer
    Dim Error_sn As Boolean
    Dim Es_Pr, Es_Var As Boolean


    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        FRMacercade.Show()
    End Sub

    Private Sub Compilador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridE.Sort(GridE.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        'inicializamos variables 
        Var_Existe = False

        'TextBox1.Text += Pr(0, 1)
        'For Each item As String In Pr
        '    TextBox1.Text += CStr(item) & " "
        'Next
        ' Dim Pr() As String = {"Proceder", "FinProceder", "Repetir", "FinRepetir", "Romper", "Sielvalor", "Ejecutar", "FinEjecutar", "Procedimiento", "FinProcedimiento", "entero", "caracter", "decimal"}

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarToolStripMenuItem.Click
        TXTcodigo.Text = ""
        TXTsalida.Text = ""
    End Sub

    Private Sub CodigoAToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoAToolStripMenuItem.Click
        TXTcodigo.Text = "entero a=3| " & vbCrLf & _
"  decimal num1=3.82,num2=4.56,num6=878.1623|"
        Inicializar()
    End Sub

    Private Sub CódigoA2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CódigoA2ToolStripMenuItem.Click
        TXTcodigo.Text = "#entero @a=3| "
        TXTcodigo.Text += "  #decimal @num1=3.82,@num2=4.56,@num6=878.1623|"
        Inicializar()
    End Sub

 
    Private Function Agregar_Espacio_Fin(ByVal txt As String) As Boolean
        If Mid(txt, Len(txt), 1) = " " Then Agregar_Espacio_Fin = False Else Agregar_Espacio_Fin = True
        'si termina en espacio no se agrega espacio al final
        'sino termina es espacio se agrega espacio al final
    End Function

    Private Sub EjecutarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EjecutarToolStripMenuItem.Click


        Try
            'TXTcodigo.Text = Replace(TXTcodigo.Text, "+", " + ")
            'TXTcodigo.Text = Replace(TXTcodigo.Text, "-", " - ")
            'TXTcodigo.Text = Replace(TXTcodigo.Text, "*", " * ")
            'TXTcodigo.Text = Replace(TXTcodigo.Text, "/", " / ")
            'TXTcodigo.Text = Replace(TXTcodigo.Text, "~", " ~ ")
            'TXTcodigo.Text = Replace(TXTcodigo.Text, "(", " ( ")
            'TXTcodigo.Text = Replace(TXTcodigo.Text, ")", " ) ")
            'TXTcodigo.Text = Replace(TXTcodigo.Text, "]", " ] ")
            'TXTcodigo.Text = Replace(TXTcodigo.Text, "[", " [ ")
            'TXTcodigo.Text = Replace(TXTcodigo.Text, "|", " | ")

            'colocar espacios antes y despues sino los hay
            Dim y As Integer = 1
            Do
                If Mid(TXTcodigo.Text, y, 1) = "+" Or Mid(TXTcodigo.Text, y, 1) = "-" Or Mid(TXTcodigo.Text, y, 1) = "*" Or Mid(TXTcodigo.Text, y, 1) = "/" Or Mid(TXTcodigo.Text, y, 1) = "~" Or Mid(TXTcodigo.Text, y, 1) = "|" Or Mid(TXTcodigo.Text, y, 1) = "[" Or Mid(TXTcodigo.Text, y, 1) = "]" Or Mid(TXTcodigo.Text, y, 1) = "(" Or Mid(TXTcodigo.Text, y, 1) = ")" Then
                    Ajustar_Cod(TXTcodigo, y)
                End If
                y += 1
                If y = TXTcodigo.Text.Length + 1 Then Exit Do
            Loop

            '  Exit Sub


            'empezamos análisis léxico
            Inicializar()
            'Dim VarInt(500) As Single
            'Dim VarChar(500) As String
            'Dim Operador(500) As String


            If Len(TXTcodigo.Text) = 0 Then Exit Sub 'sino se ha escrito nada salir

            If Agregar_Espacio_Fin(TXTcodigo.Text) = True Then TXTcodigo.Text += " " 'agrego el espacio al final


            Dim CoDigo = Replace(TXTcodigo.Text, vbCrLf, "") 'quito todos los retornos de carro vbcrlf para curarme en salud
            'CoDigo = Replace(CoDigo, "+", " + ")
            'CoDigo = Replace(CoDigo, "-", " - ")
            'CoDigo = Replace(CoDigo, "/", " / ")
            'CoDigo = Replace(CoDigo, "*", " * ")


            'aumento el contador de compilación
            Compilacion += 1

            'empieza la compilación

            'inicializamos las variables
            Cont_SENT = 1
            Cont_PR = 0
            Cont_VAR = 0
            Palabra = ""
            TXTsalida.Text = ""


            'bucle para recorrer la cadena y formar cada palabra lexica
            For a = 1 To Len(CoDigo)
                Cr(a) = Mid(CoDigo, a, 1)

                'sino es un espacio se agrega el caracter a la palabra y sino es vbcrlf y sino es una coma
                If Not Cr(a) = Chr(32) Or Not Cr(a) = vbCrLf Then
                    Palabra = Palabra & Cr(a)
                End If




                'analizar comentarios ? ?
                ' si empieza por ? leer todos los caracteres hasta que se encuentre con otro ?
                '            If Cr(a) = Chr(63) Then
                '                'avanzar hasta encontrar otro ?
                '                a = a + 1
                '                GoTo comentario
                '            End If



                'comprobamos si es un conector y lo mandamos donde va
                If Cr(a) = "<" Or Cr(a) = ">" Or Cr(a) = "=" Or Cr(a) = "+" Or Cr(a) = "-" Or Cr(a) = "*" Or Cr(a) = "/" Or Cr(a) = "(" Or Cr(a) = ")" Or Cr(a) = "[" Or Cr(a) = "]" Or Cr(a) = "~" Then

                    ' y guardamos la palabra que se encuentre antes
                    If Mid(Trim(Palabra), 1, 1) = "@" Then
                        Variable_Declarada = True

                        Guardar_Lexica(Cont_SENT, "Variable", "Null", Mid(Palabra, 2, Palabra.Length - 2))
                        'Guardar_Lexica(Cont_SENT, "Variable", "Null", Cont_VAR)
                        'sino hay variables guardadas la almacenamos de una vez
                        If GridV.Rows.Count = 0 Then

                            GridV.Rows.Add(Mid(Trim(Palabra), 2, Len(Trim(Palabra)) - 2), "", "")
                            Cont_VAR += 1
                        Else
                            'si ya hay variables guardadas comparamos
                            'revisando si existe previamente antes de proceder a almacenarla
                            For c = 0 To GridV.Rows.Count - 1
                                Console.WriteLine(GridV.Rows(c).Cells(0).Value)
                                If Mid(Trim(Palabra), 2, Len(Trim(Palabra)) - 2) = GridV.Rows(c).Cells(0).Value Then Var_Existe = True : Exit For
                            Next c
                            If Var_Existe = False Then
                                GridV.Rows.Add(Mid(Trim(Palabra), 2, Len(Trim(Palabra)) - 2), "", "")
                                Cont_VAR += 1
                            Else
                                'GridERR.Rows.Add("La variable " & Mid(Trim(Palabra), 2, Len(Trim(Palabra)) - 2) & " ya existe.") : Var_Existe = False : Var_Existe = False
                            End If

                        End If

                    End If
                    If Mid(Trim(Palabra), 1, 1) = "#" Then
                        Cont_PR += 1
                        Guardar_Lexica(Cont_SENT, "PR", Mid(Trim(Palabra), 2, Len(Trim(Palabra))))
                        If Mid(Trim(Palabra), 2, Len(Trim(Palabra))).ToUpper = "ENTERO" Or Mid(Trim(Palabra), 2, Len(Trim(Palabra))).ToUpper = "DECIMAL" Then Tipo_Var = "Numérico" Else Tipo_Var = "Alfanumérico"
                    End If
                    If IsNumeric(Mid(Trim(Palabra), 1, 1)) Then
                        If Variable_Declarada = True Then
                            Guardar_Lexica(Cont_SENT, "Numérico", Mid(Trim(Palabra), 2, Len(Trim(Palabra))))
                            GridV.Rows(Cont_VAR - 1).Cells(1).Value = "Numérico"
                            GridV.Rows(Cont_VAR - 1).Cells(2).Value = Mid(Palabra, 1, Len(Palabra) - 1)
                            Variable_Declarada = False
                        End If
                    End If
                    If Mid(Trim(Palabra), 1, 1) = Chr(22) Then
                        If Variable_Declarada = True Then
                            Guardar_Lexica(Cont_SENT, "Alfanumérico", Mid(Trim(Palabra), 2, Len(Trim(Palabra))))
                            GridV.Rows(Cont_VAR - 1).Cells(1).Value = "Alfanumérico"
                            GridV.Rows(Cont_VAR - 1).Cells(2).Value = Mid(Trim(Palabra), 2, Len(Trim(Palabra)))
                            Variable_Declarada = False
                        End If
                    End If

                    Cont_CN += 1
                    Guardar_Lexica(Cont_SENT, "Conector", Cr(a))
                    Palabra = ""

                End If



                'si es espacio o conector o fin de sentencia o una coma(,) voy a analizar si es una palabra reservada ó variable 
                If Cr(a) = Chr(32) Or Cr(a) = "," Or Cr(a) = "<" Or Cr(a) = ">" Or Cr(a) = "=" Or Cr(a) = "+" Or Cr(a) = "-" Or Cr(a) = "*" Or Cr(a) = "/" Or Cr(a) = "(" Or Cr(a) = ")" Or Cr(a) = "[" Or Cr(a) = "]" Or Cr(a) = "|" Or Cr(a) = "~" Then

                    'revisar si comienza por @ arroba ó # numeral
                    If Mid(Trim(Palabra), 1, 1) = "@" Then
                        Cont_VAR += 1
                        Variable_Declarada = True
                        'Guardar_Lexica(Cont_SENT, "Variable", "Null")
                        Guardar_Lexica(Cont_SENT, "Variable", "Null", Mid(Palabra, 2, Palabra.Length - 2))
                        'If Grid.Rows(Grid.Rows.Count).Cells(2).Value = "entero" Or Grid.Rows(3).Cells(2).Value = "decimal" Then Tipo_var = "Numérico" Else Tipo_var = "Alfanumérico"
                        GridV.Rows.Add(Mid(Trim(Palabra), 2, Len(Palabra) - 2), Tipo_Var, "")

                    End If
                    If Mid(Trim(Palabra), 1, 1) = "#" Then
                        Cont_PR += 1
                        'obtener el tipo de PR
                        For b = 0 To (Pr.Length / 2) - 1
                            If Trim(Mid(Palabra, 2)).ToUpper = Trim(Pr(b, 0)).ToUpper Then
                                Guardar_Lexica(Cont_SENT, "PR", Mid(Trim(Palabra), 2, Len(Trim(Palabra))))
                                If Mid(Trim(Palabra), 2, Len(Trim(Palabra))).ToUpper = "ENTERO" Or Mid(Trim(Palabra), 2, Len(Trim(Palabra))).ToUpper = "DECIMAL" Then Tipo_Var = "Numérico" Else Tipo_Var = "Alfanumérico"
                                Exit For
                            End If
                        Next b
                    End If
                    If IsNumeric(Mid(Trim(Palabra), 1, 1)) Then
                        Guardar_Lexica(Cont_SENT, "Numérico", Mid(Palabra, 1, Len(Palabra) - 1))
                        If Variable_Declarada = True Then
                            GridV.Rows(Cont_VAR - 1).Cells(1).Value = "Numérico"
                            GridV.Rows(Cont_VAR - 1).Cells(2).Value = Mid(Palabra, 1, Len(Palabra) - 1)
                            Variable_Declarada = False
                        End If
                    End If
                    If Mid(Trim(Palabra), 1, 1) = Chr(34) Then
                        Guardar_Lexica(Cont_SENT, "Alfanumérico", Mid(Trim(Palabra), 2, Len(Palabra) - 3))
                        If Variable_Declarada = True Then
                            GridV.Rows(Cont_VAR - 1).Cells(1).Value = "Alfanumérico"
                            GridV.Rows(Cont_VAR - 1).Cells(2).Value = Mid(Trim(Palabra), 2, Len(Palabra) - 3)
                            Variable_Declarada = False
                        End If
                    End If

                    Palabra = ""
                    'For b = 0 To Pr.Length - 1
                    'esto es en caso de revisar las PR sino utilizo el signo @al comienzo de la palabra
                    'If Trim(Palabra).ToUpper = Trim(Pr(b,0)).ToUpper Then
                    '    Cont_PR += 1
                    '    'TXTdepuracion.Text = TXTdepuracion.Text & "Palabra reservada:" & Trim(Palabra) & vbCrLf
                    '    Palabra = ""
                    '    Exit For
                    'End If

                    'Next
                    'Palabra = ""
                End If

                'si es una coma

                If Cr(a) = "," Then
                    Guardar_Lexica(Cont_SENT, "Conector", Cr(a))
                    'Palabra = ""
                End If

                'caracter separador de sentencias
                If Cr(a) = "|" Then Guardar_Lexica(Cont_SENT, "conector", "|") : Cont_SENT += 1 : Palabra = ""

                'caracteres no permitidos y que se remarquen
                If InStr("ñÑ¤¶§!%&`ÇüéâäàåçêëèïîìÄÅÉæÆôöòûùÿÖØø£Ø×ƒáíÿúªº¿®¬½¼¡«»ÁÂÀ©¢¥ãÃðÐÊËÈÍÎÏÌ¯ÓßÔÒõÕµþÞÚÛÙýÝ´±¾÷", Cr(a)) Then
                    Guardar_Lexica(Cont_SENT, "Carácter inválido", Cr(a))
                    GridERR.Rows.Add("Carácter inválido " & Cr(a) & " Sentencia: " & Cont_SENT)
                    'TXTdepuracion.Text = "Carácter no permitido: " & Cr(a) & ", posición: " & a
                    TXTcodigo.SelectionStart = a - 1
                    TXTcodigo.SelectionLength = 1
                End If



                '$%&'()*+,-./012<=>?@AF0PZ[\Z[\]^_`aabcdnxyz♪♀{|}~⌂►~⌂Çü
                'TXTsalida.Text = TXTsalida.Text & Cr(a)

            Next a

            'agregamos las estadíasticas

            GridE.Rows.Add(Compilacion, Cont_SENT - 1, Cont_PR)
            TabControl1.SelectedIndex = 1



            'continuamos análisis sintáctico


            Do Until SN_cont = Grid.Rows.Count
                If Error_sn = True Then Exit Sub
                Es_Pr = False
                Es_Var = False
                ANSIN_ns(SN_cont)

                'Do
                '    SN_cont = SN_cont + 1
                '    If SN_cont = Grid.Rows.Count - 1 Then Exit Do
                'Loop Until Grid.Rows(SN_cont).Cells(2).Value() = "|"
                'SN_cont += 1
            Loop


            'empezamos análisis semántico

            'comprobamos que los valores de las variables sean de su mismo tipo
            For a = 0 To GridV.Rows.Count - 1
                If GridV.Rows(a).Cells(1).Value = "Numérico" Then 'si el tipo es numerico comprobamos que el valor sea numérico
                    If Not IsNumeric(GridV.Rows(a).Cells(2).Value) Then GridsemE.Rows.Add("", "La variable @" & GridV.Rows(a).Cells(0).Value & " debe ser un valor numérico")
                Else ' si el tipo es alfanumérico comprobamos que el valor sea alfanumérico
                    If IsNumeric(GridV.Rows(a).Cells(2).Value) Then GridsemE.Rows.Add("", "La variable @" & GridV.Rows(a).Cells(0).Value & " debe ser un valor alfanumérico")
                End If
            Next

            'imprimir salida, buscamos las sentencias que tengan imprimir
            'si la sentencia es Imprimir entonces txtsalida.text+= lo que se encuentre luego del igual y antes de | finalización
            'se va buscando cada variable y se sustituye por su valor correspondiente

            'Buscar_variable()
            'buscar en grid lo que tenga la palabra imprimir

            'Exit Sub

            Dim Valor_celda As String
            'Dim Indice As Integer = 0
            'Dim IndiceOp As Integer = 0
            Dim Es_numerico As Integer = 0
            Dim Tint1, Tint2 As Decimal
            Dim TChar1, Tchar2 As String
            Dim Op As String = ""
            Dim ResultadoInt As Decimal = Nothing
            Dim ResultadoChar As String = Nothing
            Tint1 = Nothing : Tint2 = Nothing : TChar1 = Nothing : Tchar2 = Nothing

            For v = 0 To Grid.Rows.Count - 1
                Valor_celda = Grid.Rows(v).Cells(2).Value
                If Valor_celda.ToUpper = "IMPRIMIR" Then
                    'avanzar para ir buscando variables o valores y sus conectores, hasta que encuentre |
                    'resolver como en una calculadora t1+t2,t1-t2,t1*t2,t1/t2


                    Do

                        'SI ES VARIABLE  -   -   -   -   -   -   -   -   -
                        'buscar su valor en la tabla de variables
                        If Grid.Rows(v).Cells(1).Value = "Variable" Then
                            If Buscar_Tipo_variable(Grid.Rows(v).Cells(3).Value) = "Numérico" Then
                                If Es_numerico = 0 Then Es_numerico = 1
                                If Es_numerico = 2 Then GridsemE.Rows.Add(Grid.Rows(v).Cells(0).Value, "Se esperaba un valor alfanumérico") : TabControl1.SelectedIndex = 3 : Exit Sub
                                If Tint1 = Nothing Then Tint1 = CDec(Buscar_variable(Grid.Rows(v).Cells(3).Value)) Else Tint2 = CDec(Buscar_variable(Grid.Rows(v).Cells(3).Value))
                            End If

                            If Buscar_Tipo_variable(Grid.Rows(v).Cells(3).Value) = "Alfanumérico" Then
                                If Es_numerico = 0 Then Es_numerico = 2
                                If Es_numerico = 1 Then GridsemE.Rows.Add(Grid.Rows(v).Cells(0).Value, "Se esperaba un valor numérico") : TabControl1.SelectedIndex = 3 : Exit Sub
                                If TChar1 = Nothing Then TChar1 = Buscar_variable(Grid.Rows(v).Cells(3).Value) Else Tchar2 = Buscar_variable(Grid.Rows(v).Cells(3).Value)
                            End If
                        End If

                        'SI ES NUMÉRICO -   -   -   -   -   -   -   -   -
                        If Grid.Rows(v).Cells(1).Value = "Numérico" Then
                            If Es_numerico = 0 Then Es_numerico = 1
                            If Es_numerico = 2 Then GridsemE.Rows.Add(Grid.Rows(v).Cells(0).Value, "Se esperaba un valor alfanumérico") : TabControl1.SelectedIndex = 3 : Exit Sub
                            'SI EL T1 es Null lo mete en T1
                            If Tint1 = Nothing Then Tint1 = Grid.Rows(v).Cells(2).Value Else Tint2 = Grid.Rows(v).Cells(2).Value
                            'VarInt(Indice) = Grid.Rows(v).Cells(0).Value
                            'Indice += 1
                        End If

                        'SI ES ALFANUMÉRICO -   -   -   -   -   -   -   -   -
                        If Grid.Rows(v).Cells(1).Value = "Alfanumérico" Then
                            If Es_numerico = 0 Then Es_numerico = 2
                            If Es_numerico = 1 Then GridsemE.Rows.Add(Grid.Rows(v).Cells(0).Value, "Se esperaba un valor numérico") : TabControl1.SelectedIndex = 3 : Exit Sub
                            If TChar1 = Nothing Then TChar1 = Grid.Rows(v).Cells(2).Value Else Tchar2 = Grid.Rows(v).Cells(2).Value
                            'meter en array numérico
                            'VarChar(Indice) = Grid.Rows(v).Cells(0).Value
                            'Indice += 1
                        End If

                        'SI ES CONECTOR +-*/~   -   -   -   -   -   -   -   -   -
                        If Grid.Rows(v).Cells(1).Value = "Conector" Then
                            If Grid.Rows(v).Cells(2).Value = "+" Or Grid.Rows(v).Cells(2).Value = "-" Or Grid.Rows(v).Cells(2).Value = "*" Or Grid.Rows(v).Cells(2).Value = "/" Or Grid.Rows(v).Cells(2).Value = "~" Then
                                'Operador(IndiceOp) = Grid.Rows(v).Cells(2).Value
                                'IndiceOp += 1
                                Op = Grid.Rows(v).Cells(2).Value
                            End If
                        End If
                        v += 1

                        'resultado entero
                        If Tint1 <> 0 And Op <> "" Then
                            Select Op
                                Case Is = "~"
                                    GridsemE.Rows.Add(Grid.Rows(v).Cells(0).Value, "Se esperaba +-*/", "") : TabControl1.SelectedIndex = 3 : Exit Sub
                            End Select
                        End If

                        If Tint1 <> 0 And Tint2 <> 0 And Op <> "" Then
                            Select Case Op
                                'realizamos la operación
                                Case Is = "+"
                                    ResultadoInt = (Tint1 + Tint2)
                                Case Is = "-"
                                    ResultadoInt = (Tint1 - Tint2)
                                Case Is = "/"
                                    ResultadoInt = (Tint1 / Tint2)
                                Case Is = "*"
                                    ResultadoInt = (Tint1 * Tint2)

                            End Select
                            Tint1 = ResultadoInt
                            Tint2 = Nothing
                            Op = ""
                        End If

                        'resultado caracter
                        If TChar1 <> Nothing And Op <> "" Then
                            Select Op
                                Case Is = "+", "-", "*", "/"
                                    GridsemE.Rows.Add(Grid.Rows(v).Cells(0).Value, "Se esperaba el conector ~", "") : TabControl1.SelectedIndex = 3 : Exit Sub
                            End Select
                        End If

                        If TChar1 <> Nothing And Tchar2 <> Nothing And Op <> "" Then
                            Select Case Op
                                'concatenamos
                                Case Is = "~"
                                    ResultadoChar = (TChar1 & Tchar2)

                            End Select
                            TChar1 = ResultadoChar
                            Tchar2 = Nothing
                            Op = ""
                        End If

                    Loop Until Grid.Rows(v).Cells(2).Value = "|" 'hacer hasta que encuentre |

                    'al encontrar | muestro el resultado 
                    If Es_numerico = 1 Then TXTsalida.Text += ResultadoInt & vbCrLf
                    If Es_numerico = 2 Then TXTsalida.Text += ResultadoChar & vbCrLf

                    'INICIALIZO VARIABLES
                    Op = ""
                    Tint1 = Nothing
                    Tint2 = Nothing
                    TChar1 = Nothing
                    Tchar2 = Nothing
                    ResultadoInt = Nothing
                    ResultadoChar = Nothing
                    Es_numerico = 0

                    'aquí obtengo el resultadoOOOO -------------------------<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

                    'Dim ResultadoInt As Integer = 0
                    'Dim ResultadoChar As String = ""

                    'si es numérico
                    'If VarInt.Length = 1 Then TXTsalida.Text = TXTsalida.Text & VarInt(0) & vbCrLf : GoTo Salir ' si sólo tiene un valor lo mando como respuesta de una vez



                    'If VarInt.Length > 1 Then
                    '    For r = 0 To VarInt.Length

                    '    Next
                    'End If


                    ' si es alfanumérico
                    'If VarChar.Length = 1 Then ResultadoChar = VarChar(0) ' si sólo tiene un valor lo mando como respuesta de una vez

                    'If VarChar.Length > 1 Then
                    '    For r = 0 To VarChar.Length

                    '    Next

                    'End If


                End If 'fin PR imprimir
Salir:
            Next



        Catch ex As Exception
            MsgBox("Se ha producido un error: sorry!!!:" & vbCrLf & "La descripción del error es: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub Guardar_Lexica(ByVal Sentencia As Integer, ByVal Categoria As String, ByVal Pl As String, Optional ByVal Valor As String = "")
        Grid.Rows.Add(Sentencia, Categoria, Pl, Valor)
    End Sub
    Private Sub CódigoA3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CódigoA3ToolStripMenuItem.Click
        TXTcodigo.Text = "#entero @a=3| "
        TXTcodigo.Text += "  #decimal @num1=3.82,@num2=4.56,@num6=878.1623| @texto1=" & Chr(34) & "sldfhkskfskdsfknsdfkl" & Chr(34)
        Inicializar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim resp = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo)
        If resp = MsgBoxResult.Yes Then End

    End Sub
    Private Function ANSIN_ns(ByVal inicio As Integer) As Boolean
        ' si llega al final de la lista no continuar GridE.Rows.Count
        'GridE.CurrentRow.Cells(0).Value

        'If ANSIN_Sent = Grid.Rows(1).Cells(1).Value() Then 'mientras sea la misma sentencia continuamos analizando

        'lo primero que encuentre siempre debe ser una P.R o una variable
        'revisar si la primera p.l es una p.r
        'sino es una p.r indicamos el error y detenemos

        Dim v2 As String = Grid.Rows(0 + SN_cont).Cells(2).Value()
        'Dim v1 As String

        'revisar si es P.R
        For b = 0 To (Pr.Length / 2) - 1
            'esto es en caso de revisar las PR sino utilizo el signo @al comienzo de la palabra
            If v2.ToUpper = Trim(Pr(b, 0)).ToUpper Then Es_Pr = True : Exit For
        Next b

        'revisar si es una variable
        'If Es_Pr = False Then
        '    For d = 0 To GridV.Rows.Count - 1
        '        v1 = GridV.Rows(d).Cells(0).Value()
        '        If v1.ToUpper = v2.ToUpper Then Es_Var = True : Exit For
        '    Next d
        'End If

        If v2 = "Null" Then Es_Var = True
        If Es_Pr = False And Es_Var = False Then GridSinE.Rows.Add(Grid.Rows(0 + SN_cont).Cells(0).Value(), "La primera instrucción de la sentencia debe ser una palabra reservada o variable", "") : Error_sn = True : Exit Function




        'si l sentencia tiene menos de 3 palabras léxicas no analizar, saltar a la siguiente sentencia


        'si comienza por palabra reservada

        Select Case v2.ToUpper
            Case Is = "ENTERO", "DECIMAL", "CARACTER"
                Debug.Print(Grid.Rows(0 + SN_cont).Cells(2).Value() & " -- " & SN_cont)
                SN_cont += 1
ContinuaVar:
                'lo segundo (obligatorio) debe ser una variable
                If Grid.Rows(SN_cont).Cells(2).Value() <> "Null" Then GridSinE.Rows.Add(Grid.Rows(SN_cont).Cells(0).Value(), "Se esperaba una variable", "") : Error_sn = True : Exit Function
                Debug.Print(Grid.Rows(SN_cont).Cells(2).Value() & " -- " & SN_cont)
                SN_cont += 1

                'lo tercero (obligatorio) debe ser = , |
                If Grid.Rows(SN_cont).Cells(2).Value() <> "=" And Grid.Rows(SN_cont).Cells(2).Value() <> "," And Grid.Rows(SN_cont).Cells(2).Value() <> "|" Then GridSinE.Rows.Add(Grid.Rows(SN_cont).Cells(0).Value(), "Se esperaba =,|", "") : Error_sn = True : Exit Function

                'si lo tercero es una coma significa que sigue introduciendo variables
                If Grid.Rows(SN_cont).Cells(2).Value() = "," Then
                    Debug.Print(Grid.Rows(SN_cont).Cells(2).Value() & " -- " & SN_cont)
                    'debemos empezar a comprobar por el segundo miembro
                    SN_cont += 1
                    GoTo ContinuaVar
                End If

                'si lo tercero es igual a | lo que sigue es una instruccion nueva
                If Grid.Rows(SN_cont).Cells(2).Value() = "|" Then SN_cont += 1 : Exit Function
                'If Grid.Rows(SN_cont).Cells(2).Value() <> "=" Then SN_cont += 1 : Exit Function


                Debug.Print(Grid.Rows(SN_cont).Cells(2).Value() & " -- " & SN_cont)
                SN_cont += 1

                'lo cuarto (opcional) debe ser valor o variable si el 3ero es =
                If Grid.Rows(SN_cont - 1).Cells(2).Value() = "=" Then
                    If Grid.Rows(SN_cont).Cells(2).Value() <> "Null" And Grid.Rows(SN_cont).Cells(1).Value() <> "Numérico" And Grid.Rows(SN_cont).Cells(1).Value() <> "Alfanumérico" Then GridSinE.Rows.Add(Grid.Rows(SN_cont).Cells(0).Value(), Grid.Rows(SN_cont).Cells(2).Value() & " se esperaba un valor o variable", "") : Error_sn = True : Exit Function
                    Debug.Print(Grid.Rows(SN_cont).Cells(2).Value() & " -- " & SN_cont)
                End If
                SN_cont += 1

                'si el quinto es | salta a la siguiente sentencia
                If Grid.Rows(SN_cont).Cells(2).Value() = "|" Then SN_cont += 1 : Exit Function

                'si el quinto es una coma significa que sigue introduciendo variables
                If Grid.Rows(SN_cont).Cells(2).Value() = "," Then
                    Debug.Print(Grid.Rows(SN_cont).Cells(2).Value() & " -- " & SN_cont)
                    'debemos empezar a comprobar por el segundo miembro
                    SN_cont += 1
                    GoTo ContinuaVar
                End If

                'si el 5to es , lo sexto (obligatorio) debe ser una variable 
                If Grid.Rows(SN_cont).Cells(2).Value() = "," Then
                    If Grid.Rows(SN_cont + 1).Cells(2).Value() <> "Null" Then GridSinE.Rows.Add(Grid.Rows(SN_cont).Cells(0).Value(), "Se esperaba una variable", "") : Error_sn = True : Exit Function
                    Debug.Print(Grid.Rows(SN_cont).Cells(2).Value() & " -- " & SN_cont)
                End If



                'si el quinto es distinto que | y que una coma es un error sintactico
                If Grid.Rows(SN_cont).Cells(2).Value() <> "|" And Grid.Rows(SN_cont).Cells(2).Value() <> "," Then
                    GridSinE.Rows.Add(Grid.Rows(SN_cont).Cells(0).Value(), "Se esperaba ,| ", "") : Error_sn = True : Exit Function
                End If
                SN_cont += 1

                'si es imprimir
            Case Is = "IMPRIMIR"
                SN_cont = Grid.Rows.Count


                'si comienza por variable
            Case Is = "NULL"
                SN_cont += 1
                'lo segundo (obligatorio) debe ser =
                If Grid.Rows(SN_cont).Cells(2).Value() <> "=" Then GridSinE.Rows.Add(Grid.Rows(SN_cont).Cells(0).Value(), "Se esperaba = ", "") : Error_sn = True : Exit Function


                'si existe tercero debe ser valor o variable
                SN_cont += 1
                If Not SN_cont = Grid.Rows.Count Then
                    If Grid.Rows(SN_cont).Cells(2).Value() <> "Null" And Grid.Rows(SN_cont).Cells(1).Value() <> "Numérico" And Grid.Rows(SN_cont).Cells(1).Value() <> "Alfanumérico" Then GridSinE.Rows.Add(Grid.Rows(SN_cont).Cells(0).Value(), "Se esperaba valor o variable ", "") : Error_sn = True : Exit Function
                Else
                    Exit Function
                End If
                SN_cont += 1

ChequearAntes:
                'lo cuarto (opcional) debe ser +-*/~|
                If Not SN_cont = Grid.Rows.Count Then 'sino ha llegado a su fin
                    If Grid.Rows(SN_cont).Cells(2).Value() <> "+" And Grid.Rows(SN_cont).Cells(2).Value() <> "-" And Grid.Rows(SN_cont).Cells(2).Value() <> "*" And Grid.Rows(SN_cont).Cells(2).Value() <> "/" And Grid.Rows(SN_cont).Cells(2).Value() <> "~" And Grid.Rows(SN_cont).Cells(2).Value() <> "|" Then GridSinE.Rows.Add(Grid.Rows(SN_cont).Cells(0).Value(), "Se esperaba +-*/~ ", "") : Error_sn = True : Exit Function
                Else
                    Exit Function
                End If
                SN_cont += 1



                'el quinto debe ser valor o variable si el cuarto es +-*/~|
                If Not SN_cont = Grid.Rows.Count Then 'sino ha llegado a su fin
                    If Grid.Rows(SN_cont).Cells(2).Value() <> "Null" And Grid.Rows(SN_cont).Cells(1).Value() <> "Numérico" And Grid.Rows(SN_cont).Cells(1).Value() <> "Alfanumérico" Then GridSinE.Rows.Add(Grid.Rows(SN_cont).Cells(0).Value(), "Se esperaba valor o variable ", "") : Error_sn = True : Exit Function
                Else
                    Exit Function
                End If
                SN_cont += 1

                'si el sexto no es fin de instrucción continuamos comparando desde el 4to
                If Not SN_cont = Grid.Rows.Count Then 'sino ha llegado a su fin
                    If Grid.Rows(SN_cont).Cells(2).Value() <> "|" Then GoTo ChequearAntes
                Else
                    Exit Function
                End If

        End Select


    End Function

    Private Sub QuitarCarácteresDeRetornoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarCarácteresDeRetornoToolStripMenuItem.Click
        TXTcodigo.Text = Replace(TXTcodigo.Text, vbCrLf, "")
    End Sub
    Private Sub Inicializar()
        Grid.Rows.Clear()
        GridV.Rows.Clear()
        GridERR.Rows.Clear()
        GridSinE.Rows.Clear()
        GridsemE.Rows.Clear()
        Es_Pr = False
        Es_Var = False
        SN_cont = 0
        Error_sn = False
        Var_Existe = False
    End Sub

    Private Sub CódigoA4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CódigoA4ToolStripMenuItem.Click
        TXTcodigo.Text = "#entero @a=10|#entero @b=9 |"
        TXTcodigo.Text += "  #decimal @num1=3.82,@num2=4.56,@num6=878.1623|  #caracter @texto1=" & Chr(34) & "sldfhkskfskdsfknsdfkl" & Chr(34)
        TXTcodigo.Text += "|  #Imprimir (@a+@b)|"
        Inicializar()
    End Sub
    Private Function Buscar_variable(ByRef Var As String) As String
        For m = 0 To GridV.Rows.Count
            If GridV.Rows(m).Cells(0).Value = Var Then Buscar_variable = GridV.Rows(m).Cells(2).Value : Exit Function
        Next

        Buscar_variable = ""

    End Function
    Private Function Buscar_Tipo_variable(ByRef Var As String) As String
        For m = 0 To GridV.Rows.Count
            If GridV.Rows(m).Cells(0).Value = Var Then Buscar_Tipo_variable = GridV.Rows(m).Cells(1).Value : Exit Function
        Next

        Buscar_Tipo_variable = ""
    End Function

    Private Sub BToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BToolStripMenuItem.Click
        TXTcodigo.Text = "#entero @a=10|#entero @b=9 |"
        TXTcodigo.Text += "  #decimal @num1=3.82,@num2=4.56,@num6=878.1623"
        TXTcodigo.Text += "|  #Imprimir (10+9-2)|#Imprimir (5*3)|"
        Inicializar()
    End Sub
    Private Sub Ajustar_Cod(ByRef Tbox As TextBox, ByVal Pos As Integer)
        If Mid(Tbox.Text, Pos + 1, 1) <> " " Then Tbox.Text = Tbox.Text.Insert(Pos, " ")
        If Mid(Tbox.Text, Pos - 1, 1) <> " " Then Tbox.Text = Tbox.Text.Insert(Pos - 1, " ")
    End Sub

    Private Sub B2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2ToolStripMenuItem.Click
        TXTcodigo.Text = " #entero @a=10 | #entero @b=9 |  #decimal @num1=3.82,@num2=4.56,@num6=878.1623 |  #Imprimir ( @a + 9.2 - 2 ) | #Imprimir ( 5.2 * 3 * @a ) | "
    End Sub

    Private Sub B3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3ToolStripMenuItem.Click
        TXTcodigo.Text = "#entero @a=10 | #entero @b=9 |  #decimal @num1=3.82,@num2=4.56,@num6=878.1623 | #caracter @nec = " & Chr(34) & "quiero" & Chr(34) & " | #Imprimir ( @a + 9.2 - 2 ) | #Imprimir ( 5.2 * 3 * @a ) | #IMPrimir ( @num1 * @num2 ) | #imprimIR ( @nec ~ " & Chr(34) & "comer" & Chr(34) & "~" & Chr(34) & "pizza" & Chr(34) & " ) | "
    End Sub
End Class
