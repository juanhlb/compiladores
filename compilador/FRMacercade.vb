Public Class FRMacercade

    Private Sub FRMacercade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TXTinfo.Text = "P.R: " & vbCrLf & _
"#Proceder, #FinProceder, #Repetir, #FinRepetir," & vbCrLf & _
"#Romper ,#Sielvalor,#Ejecutar,#FinEjecutar,#Procedimiento,#FinProcedimiento,#entero,#car" & vbCrLf & _
"acter,#decimal" & vbCrLf & _
"Todas las variables comenzarán con un signo @ arroba" & vbCrLf & _
"Todas las palabras reservadas comenzarán con un signo # numeral" & vbCrLf & _
"Los caracteres no incluidos:" & vbCrLf & _
"ñÑ¤¶§!%&`ÇüéâäàåçêëèïîìÄÅÉæÆôöòûùÿÖØø£Ø×ƒáíÿúªº¿®¬½¼¡«»ÁÂÀ©¢¥ãÃðÐÊËÈÍÎÏÌ¯ÓßÔ" & vbCrLf & _
"ÒõÕµþÞÚÛÙýÝ´±¾÷" & vbCrLf & _
"El caracter para separar las instrucciones sería | barra vertical" & vbCrLf & _
"Caracter para concatenar cadenas ~" & vbCrLf & _
"Para definir las variables sería:" & vbCrLf & _
"# entero @cantidad=2350|#caracter @titulo1=abcdef| #decimal @valor1=158736.33 |" & vbCrLf & _
"Se puede dar el caso de que @cantidad esté definido como tipo entero pero no esté" & vbCrLf & _
"        inicializado()" & vbCrLf & _
"# entero @cantidad|" & vbCrLf & _
"De igual manera pueden definirse varias variables de un mismo tipo separadas por coma" & vbCrLf & _
"#caracter @nombre,@apellido,@ciudad,@direccion|" & vbCrLf & _
"#Proceder| ?vendría a ser un Do, se repiten todas las intrucciones que hayan hasta" & vbCrLf & _
"        FinRepetir()" & vbCrLf & _
"#FinProceder|" & vbCrLf & _
"#Romper| ?para salir de un bucle Proceder" & vbCrLf & _
"#Repetir (0:5:1)|" & vbCrLf & _
"#FinRepetir|" & vbCrLf & _
"?quiere decir q se repita desde cero hasta 5 de uno en uno" & vbCrLf & _
"#Sielvalor @ax = 3 #Ejecutar|#FinEjecutar |" & vbCrLf & _
"#Procedimiento ()|" & vbCrLf & _
"#FinProcedimiento|" & vbCrLf & _
"?comentario de línea comienza con signo de interrogación"
    End Sub
End Class