Public Class Form1
    Dim objromano = New conversor_romanos




    Class conversor_romanos
    Public depto() As String = {"Seleccione un depto.", "Usulutan", "San Miguel", "La Union", "Morazan"}
    Dim mun()() As String = {
               New String() {"Seleccione un depto."},
        New String() {"Seleccione un municipio", "Usulutan", "Jiquilisco", "Santa Elena", "Santa Maria"},    '0->Usulutan
        New String() {"Seleccione un municipio", "San Miguel", "El Transito", "San Rafael Ote", "San Jorge"},'1->San Miguel
        New String() {"Seleccione un municipio", "La Union", "SRL", "Anamoros", "Bolivar"},                  '2->La Union
        New String() {"Seleccione un municipio", "Arambala", "Perquin", "Corinto", "Cacaopera"},              '3->Morazan
        New String() {"Seleccione un municipio", "San Salvador"}
    }

    Dim u, d, c, temp As Integer


End Class