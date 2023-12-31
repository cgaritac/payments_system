﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="BDPLANILLA")>  _
Partial Public Class DatosPlanilla
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definiciones de métodos de extensibilidad"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertTBSALARIOS(instance As TBSALARIOS)
    End Sub
  Partial Private Sub UpdateTBSALARIOS(instance As TBSALARIOS)
    End Sub
  Partial Private Sub DeleteTBSALARIOS(instance As TBSALARIOS)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.GestionPlanilla.My.MySettings.Default.BDPLANILLAConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property TBSALARIOS() As System.Data.Linq.Table(Of TBSALARIOS)
		Get
			Return Me.GetTable(Of TBSALARIOS)
		End Get
	End Property
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.BUSCAR")>  _
	Public Function BUSCAR(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="CDEMPLEADO", DbType:="Int")> ByVal cDEMPLEADO As System.Nullable(Of Integer), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="MSJ", DbType:="VarChar(50)")> ByRef mSJ As String) As ISingleResult(Of BUSCARResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), cDEMPLEADO, mSJ)
		mSJ = CType(result.GetParameterValue(1),String)
		Return CType(result.ReturnValue,ISingleResult(Of BUSCARResult))
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.ELIMINAR")>  _
	Public Function ELIMINAR(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="CDEMPLEADO", DbType:="Int")> ByVal cDEMPLEADO As System.Nullable(Of Integer), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="MSJ", DbType:="VarChar(50)")> ByRef mSJ As String) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), cDEMPLEADO, mSJ)
		mSJ = CType(result.GetParameterValue(1),String)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.GUARDAR_SALARIO")>  _
	Public Function GUARDAR_SALARIO(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="ID", DbType:="Int")> ByRef iD As System.Nullable(Of Integer), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="CDEMPLEADO", DbType:="Int")> ByVal cDEMPLEADO As System.Nullable(Of Integer), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="NOMBRE", DbType:="VarChar(20)")> ByVal nOMBRE As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="APELLIDOS", DbType:="VarChar(20)")> ByVal aPELLIDOS As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="DEPARTAMENTO", DbType:="VarChar(25)")> ByVal dEPARTAMENTO As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="TELEFONO", DbType:="VarChar(15)")> ByVal tELEFONO As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="SALARIOMENSUAL", DbType:="Float")> ByVal sALARIOMENSUAL As System.Nullable(Of Double), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="CCSS", DbType:="Float")> ByVal cCSS As System.Nullable(Of Double), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="BANCOPOPULAR", DbType:="Float")> ByVal bANCOPOPULAR As System.Nullable(Of Double), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="FECHADEPAGO", DbType:="Date")> ByVal fECHADEPAGO As System.Nullable(Of Date), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="MSJ", DbType:="VarChar(50)")> ByRef mSJ As String) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), iD, cDEMPLEADO, nOMBRE, aPELLIDOS, dEPARTAMENTO, tELEFONO, sALARIOMENSUAL, cCSS, bANCOPOPULAR, fECHADEPAGO, mSJ)
		iD = CType(result.GetParameterValue(0),System.Nullable(Of Integer))
		mSJ = CType(result.GetParameterValue(10),String)
		Return CType(result.ReturnValue,Integer)
	End Function
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.TBSALARIOS")>  _
Partial Public Class TBSALARIOS
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _CDEMPLEADO As Integer
	
	Private _NOMBRE As String
	
	Private _APELLIDOS As String
	
	Private _DEPARTAMENTO As String
	
	Private _TELEFONO As String
	
	Private _SALARIOMENSUAL As System.Nullable(Of Double)
	
	Private _CCSS As System.Nullable(Of Double)
	
	Private _BANCOPOPULAR As System.Nullable(Of Double)
	
	Private _FECHADEPAGO As System.Nullable(Of Date)
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnCDEMPLEADOChanging(value As Integer)
    End Sub
    Partial Private Sub OnCDEMPLEADOChanged()
    End Sub
    Partial Private Sub OnNOMBREChanging(value As String)
    End Sub
    Partial Private Sub OnNOMBREChanged()
    End Sub
    Partial Private Sub OnAPELLIDOSChanging(value As String)
    End Sub
    Partial Private Sub OnAPELLIDOSChanged()
    End Sub
    Partial Private Sub OnDEPARTAMENTOChanging(value As String)
    End Sub
    Partial Private Sub OnDEPARTAMENTOChanged()
    End Sub
    Partial Private Sub OnTELEFONOChanging(value As String)
    End Sub
    Partial Private Sub OnTELEFONOChanged()
    End Sub
    Partial Private Sub OnSALARIOMENSUALChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnSALARIOMENSUALChanged()
    End Sub
    Partial Private Sub OnCCSSChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnCCSSChanged()
    End Sub
    Partial Private Sub OnBANCOPOPULARChanging(value As System.Nullable(Of Double))
    End Sub
    Partial Private Sub OnBANCOPOPULARChanged()
    End Sub
    Partial Private Sub OnFECHADEPAGOChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnFECHADEPAGOChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.Always, DbType:="Int NOT NULL IDENTITY", IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CDEMPLEADO", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property CDEMPLEADO() As Integer
		Get
			Return Me._CDEMPLEADO
		End Get
		Set
			If ((Me._CDEMPLEADO = value)  _
						= false) Then
				Me.OnCDEMPLEADOChanging(value)
				Me.SendPropertyChanging
				Me._CDEMPLEADO = value
				Me.SendPropertyChanged("CDEMPLEADO")
				Me.OnCDEMPLEADOChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NOMBRE", DbType:="VarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property NOMBRE() As String
		Get
			Return Me._NOMBRE
		End Get
		Set
			If (String.Equals(Me._NOMBRE, value) = false) Then
				Me.OnNOMBREChanging(value)
				Me.SendPropertyChanging
				Me._NOMBRE = value
				Me.SendPropertyChanged("NOMBRE")
				Me.OnNOMBREChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_APELLIDOS", DbType:="VarChar(20) NOT NULL", CanBeNull:=false)>  _
	Public Property APELLIDOS() As String
		Get
			Return Me._APELLIDOS
		End Get
		Set
			If (String.Equals(Me._APELLIDOS, value) = false) Then
				Me.OnAPELLIDOSChanging(value)
				Me.SendPropertyChanging
				Me._APELLIDOS = value
				Me.SendPropertyChanged("APELLIDOS")
				Me.OnAPELLIDOSChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DEPARTAMENTO", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property DEPARTAMENTO() As String
		Get
			Return Me._DEPARTAMENTO
		End Get
		Set
			If (String.Equals(Me._DEPARTAMENTO, value) = false) Then
				Me.OnDEPARTAMENTOChanging(value)
				Me.SendPropertyChanging
				Me._DEPARTAMENTO = value
				Me.SendPropertyChanged("DEPARTAMENTO")
				Me.OnDEPARTAMENTOChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TELEFONO", DbType:="VarChar(15)")>  _
	Public Property TELEFONO() As String
		Get
			Return Me._TELEFONO
		End Get
		Set
			If (String.Equals(Me._TELEFONO, value) = false) Then
				Me.OnTELEFONOChanging(value)
				Me.SendPropertyChanging
				Me._TELEFONO = value
				Me.SendPropertyChanged("TELEFONO")
				Me.OnTELEFONOChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SALARIOMENSUAL", DbType:="Float")>  _
	Public Property SALARIOMENSUAL() As System.Nullable(Of Double)
		Get
			Return Me._SALARIOMENSUAL
		End Get
		Set
			If (Me._SALARIOMENSUAL.Equals(value) = false) Then
				Me.OnSALARIOMENSUALChanging(value)
				Me.SendPropertyChanging
				Me._SALARIOMENSUAL = value
				Me.SendPropertyChanged("SALARIOMENSUAL")
				Me.OnSALARIOMENSUALChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CCSS", DbType:="Float")>  _
	Public Property CCSS() As System.Nullable(Of Double)
		Get
			Return Me._CCSS
		End Get
		Set
			If (Me._CCSS.Equals(value) = false) Then
				Me.OnCCSSChanging(value)
				Me.SendPropertyChanging
				Me._CCSS = value
				Me.SendPropertyChanged("CCSS")
				Me.OnCCSSChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BANCOPOPULAR", DbType:="Float")>  _
	Public Property BANCOPOPULAR() As System.Nullable(Of Double)
		Get
			Return Me._BANCOPOPULAR
		End Get
		Set
			If (Me._BANCOPOPULAR.Equals(value) = false) Then
				Me.OnBANCOPOPULARChanging(value)
				Me.SendPropertyChanging
				Me._BANCOPOPULAR = value
				Me.SendPropertyChanged("BANCOPOPULAR")
				Me.OnBANCOPOPULARChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FECHADEPAGO", DbType:="Date")>  _
	Public Property FECHADEPAGO() As System.Nullable(Of Date)
		Get
			Return Me._FECHADEPAGO
		End Get
		Set
			If (Me._FECHADEPAGO.Equals(value) = false) Then
				Me.OnFECHADEPAGOChanging(value)
				Me.SendPropertyChanging
				Me._FECHADEPAGO = value
				Me.SendPropertyChanged("FECHADEPAGO")
				Me.OnFECHADEPAGOChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

Partial Public Class BUSCARResult
	
	Private _ID As Integer
	
	Private _CDEMPLEADO As Integer
	
	Private _NOMBRE As String
	
	Private _APELLIDOS As String
	
	Private _DEPARTAMENTO As String
	
	Private _TELEFONO As String
	
	Private _SALARIOMENSUAL As System.Nullable(Of Double)
	
	Private _CCSS As System.Nullable(Of Double)
	
	Private _BANCOPOPULAR As System.Nullable(Of Double)
	
	Private _FECHADEPAGO As System.Nullable(Of Date)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", DbType:="Int NOT NULL")>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me._ID = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CDEMPLEADO", DbType:="Int NOT NULL")>  _
	Public Property CDEMPLEADO() As Integer
		Get
			Return Me._CDEMPLEADO
		End Get
		Set
			If ((Me._CDEMPLEADO = value)  _
						= false) Then
				Me._CDEMPLEADO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NOMBRE", DbType:="VarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property NOMBRE() As String
		Get
			Return Me._NOMBRE
		End Get
		Set
			If (String.Equals(Me._NOMBRE, value) = false) Then
				Me._NOMBRE = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_APELLIDOS", DbType:="VarChar(20) NOT NULL", CanBeNull:=false)>  _
	Public Property APELLIDOS() As String
		Get
			Return Me._APELLIDOS
		End Get
		Set
			If (String.Equals(Me._APELLIDOS, value) = false) Then
				Me._APELLIDOS = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DEPARTAMENTO", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property DEPARTAMENTO() As String
		Get
			Return Me._DEPARTAMENTO
		End Get
		Set
			If (String.Equals(Me._DEPARTAMENTO, value) = false) Then
				Me._DEPARTAMENTO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TELEFONO", DbType:="VarChar(15)")>  _
	Public Property TELEFONO() As String
		Get
			Return Me._TELEFONO
		End Get
		Set
			If (String.Equals(Me._TELEFONO, value) = false) Then
				Me._TELEFONO = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SALARIOMENSUAL", DbType:="Float")>  _
	Public Property SALARIOMENSUAL() As System.Nullable(Of Double)
		Get
			Return Me._SALARIOMENSUAL
		End Get
		Set
			If (Me._SALARIOMENSUAL.Equals(value) = false) Then
				Me._SALARIOMENSUAL = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CCSS", DbType:="Float")>  _
	Public Property CCSS() As System.Nullable(Of Double)
		Get
			Return Me._CCSS
		End Get
		Set
			If (Me._CCSS.Equals(value) = false) Then
				Me._CCSS = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BANCOPOPULAR", DbType:="Float")>  _
	Public Property BANCOPOPULAR() As System.Nullable(Of Double)
		Get
			Return Me._BANCOPOPULAR
		End Get
		Set
			If (Me._BANCOPOPULAR.Equals(value) = false) Then
				Me._BANCOPOPULAR = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FECHADEPAGO", DbType:="Date")>  _
	Public Property FECHADEPAGO() As System.Nullable(Of Date)
		Get
			Return Me._FECHADEPAGO
		End Get
		Set
			If (Me._FECHADEPAGO.Equals(value) = false) Then
				Me._FECHADEPAGO = value
			End If
		End Set
	End Property
End Class
