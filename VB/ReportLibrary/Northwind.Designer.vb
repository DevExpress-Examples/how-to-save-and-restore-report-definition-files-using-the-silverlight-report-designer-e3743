﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

<Assembly: EdmSchemaAttribute()>
#Region "EDM Relationship Metadata"

<Assembly: EdmRelationshipAttribute("NORTHWNDModel", "FK_Products_Categories", "Categories", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, GetType(ReportLibrary.Categories), "Products", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(ReportLibrary.Products), True)>

#End Region

Namespace ReportLibrary
	#Region "Contexts"

	''' <summary>
	''' No Metadata Documentation available.
	''' </summary>
	Partial Public Class Northwind
		Inherits ObjectContext
		#Region "Constructors"

		''' <summary>
		''' Initializes a new Northwind object using the connection string found in the 'Northwind' section of the application configuration file.
		''' </summary>
		Public Sub New()
			MyBase.New("name=Northwind", "Northwind")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		''' <summary>
		''' Initialize a new Northwind object.
		''' </summary>
		Public Sub New(ByVal connectionString As String)
			MyBase.New(connectionString, "Northwind")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		''' <summary>
		''' Initialize a new Northwind object.
		''' </summary>
		Public Sub New(ByVal connection As EntityConnection)
			MyBase.New(connection, "Northwind")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		#End Region

		#Region "Partial Methods"

		Partial Private Sub OnContextCreated()
		End Sub

		#End Region

		#Region "ObjectSet Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		Public ReadOnly Property Categories() As ObjectSet(Of Categories)
			Get
				If (_Categories Is Nothing) Then
					_Categories = MyBase.CreateObjectSet(Of Categories)("Categories")
				End If
				Return _Categories
			End Get
		End Property
		Private _Categories As ObjectSet(Of Categories)

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		Public ReadOnly Property Products() As ObjectSet(Of Products)
			Get
				If (_Products Is Nothing) Then
					_Products = MyBase.CreateObjectSet(Of Products)("Products")
				End If
				Return _Products
			End Get
		End Property
		Private _Products As ObjectSet(Of Products)

		#End Region
		#Region "AddTo Methods"

		''' <summary>
		''' Deprecated Method for adding a new object to the Categories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
		''' </summary>
		Public Sub AddToCategories(ByVal categories As Categories)
			MyBase.AddObject("Categories", categories)
		End Sub

		''' <summary>
		''' Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
		''' </summary>
		Public Sub AddToProducts(ByVal products As Products)
			MyBase.AddObject("Products", products)
		End Sub

		#End Region
	End Class


	#End Region

	#Region "Entities"

	''' <summary>
	''' No Metadata Documentation available.
	''' </summary>
	<EdmEntityTypeAttribute(NamespaceName:="NORTHWNDModel", Name:="Categories"), Serializable(), DataContractAttribute(IsReference:=True)> _
	Partial Public Class Categories
		Inherits EntityObject
		#Region "Factory Method"

		''' <summary>
		''' Create a new Categories object.
		''' </summary>
		''' <param name="categoryID">Initial value of the CategoryID property.</param>
		''' <param name="categoryName">Initial value of the CategoryName property.</param>
		Public Shared Function CreateCategories(ByVal categoryID As Global.System.Int32, ByVal categoryName As Global.System.String) As Categories
			Dim categories As New Categories()
			categories.CategoryID = categoryID
			categories.CategoryName = categoryName
			Return categories
		End Function

		#End Region
		#Region "Primitive Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property CategoryID() As Global.System.Int32
			Get
				Return _CategoryID
			End Get
			Set(ByVal value As System.Int32)
				If _CategoryID <> value Then
					OnCategoryIDChanging(value)
					ReportPropertyChanging("CategoryID")
					_CategoryID = StructuralObject.SetValidValue(value)
					ReportPropertyChanged("CategoryID")
					OnCategoryIDChanged()
				End If
			End Set
		End Property
		Private _CategoryID As Global.System.Int32
		Partial Private Sub OnCategoryIDChanging(ByVal value As Global.System.Int32)
		End Sub
		Partial Private Sub OnCategoryIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=False), DataMemberAttribute()> _
		Public Property CategoryName() As Global.System.String
			Get
				Return _CategoryName
			End Get
			Set(ByVal value As System.String)
				OnCategoryNameChanging(value)
				ReportPropertyChanging("CategoryName")
				_CategoryName = StructuralObject.SetValidValue(value, False)
				ReportPropertyChanged("CategoryName")
				OnCategoryNameChanged()
			End Set
		End Property
		Private _CategoryName As Global.System.String
		Partial Private Sub OnCategoryNameChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnCategoryNameChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Description() As Global.System.String
			Get
				Return _Description
			End Get
			Set(ByVal value As System.String)
				OnDescriptionChanging(value)
				ReportPropertyChanging("Description")
				_Description = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Description")
				OnDescriptionChanged()
			End Set
		End Property
		Private _Description As Global.System.String
		Partial Private Sub OnDescriptionChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnDescriptionChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Picture() As Global.System.Byte()
			Get
				Return StructuralObject.GetValidValue(_Picture)
			End Get
			Set(ByVal value As System.Byte())
				OnPictureChanging(value)
				ReportPropertyChanging("Picture")
				_Picture = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Picture")
				OnPictureChanged()
			End Set
		End Property
		Private _Picture() As Global.System.Byte
		Partial Private Sub OnPictureChanging(ByVal value() As Global.System.Byte)
		End Sub
		Partial Private Sub OnPictureChanged()
		End Sub

		#End Region

		#Region "Navigation Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<XmlIgnoreAttribute(), SoapIgnoreAttribute(), DataMemberAttribute(), EdmRelationshipNavigationPropertyAttribute("NORTHWNDModel", "FK_Products_Categories", "Products")> _
		Public Property Products() As EntityCollection(Of Products)
			Get
				Return (CType(Me, IEntityWithRelationships)).RelationshipManager.GetRelatedCollection(Of Products)("NORTHWNDModel.FK_Products_Categories", "Products")
			End Get
			Set(ByVal value As EntityCollection(Of Products))
				If (value IsNot Nothing) Then
					CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of Products)("NORTHWNDModel.FK_Products_Categories", "Products", value)
				End If
			End Set
		End Property

		#End Region
	End Class

	''' <summary>
	''' No Metadata Documentation available.
	''' </summary>
	<EdmEntityTypeAttribute(NamespaceName:="NORTHWNDModel", Name:="Products"), Serializable(), DataContractAttribute(IsReference:=True)> _
	Partial Public Class Products
		Inherits EntityObject
		#Region "Factory Method"

		''' <summary>
		''' Create a new Products object.
		''' </summary>
		''' <param name="productID">Initial value of the ProductID property.</param>
		''' <param name="productName">Initial value of the ProductName property.</param>
		''' <param name="discontinued">Initial value of the Discontinued property.</param>
		Public Shared Function CreateProducts(ByVal productID As Global.System.Int32, ByVal productName As Global.System.String, ByVal discontinued As Global.System.Boolean) As Products
			Dim products As New Products()
			products.ProductID = productID
			products.ProductName = productName
			products.Discontinued = discontinued
			Return products
		End Function

		#End Region
		#Region "Primitive Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property ProductID() As Global.System.Int32
			Get
				Return _ProductID
			End Get
			Set(ByVal value As System.Int32)
				If _ProductID <> value Then
					OnProductIDChanging(value)
					ReportPropertyChanging("ProductID")
					_ProductID = StructuralObject.SetValidValue(value)
					ReportPropertyChanged("ProductID")
					OnProductIDChanged()
				End If
			End Set
		End Property
		Private _ProductID As Global.System.Int32
		Partial Private Sub OnProductIDChanging(ByVal value As Global.System.Int32)
		End Sub
		Partial Private Sub OnProductIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=False), DataMemberAttribute()> _
		Public Property ProductName() As Global.System.String
			Get
				Return _ProductName
			End Get
			Set(ByVal value As System.String)
				OnProductNameChanging(value)
				ReportPropertyChanging("ProductName")
				_ProductName = StructuralObject.SetValidValue(value, False)
				ReportPropertyChanged("ProductName")
				OnProductNameChanged()
			End Set
		End Property
		Private _ProductName As Global.System.String
		Partial Private Sub OnProductNameChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnProductNameChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property SupplierID() As Global.System.Int32?
			Get
				Return _SupplierID
			End Get
			Set(ByVal value? As System.Int32)
				OnSupplierIDChanging(value)
				ReportPropertyChanging("SupplierID")
				_SupplierID = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("SupplierID")
				OnSupplierIDChanged()
			End Set
		End Property
		Private _SupplierID? As Global.System.Int32
		Partial Private Sub OnSupplierIDChanging(ByVal value? As Global.System.Int32)
		End Sub
		Partial Private Sub OnSupplierIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property CategoryID() As Global.System.Int32?
			Get
				Return _CategoryID
			End Get
			Set(ByVal value? As System.Int32)
				OnCategoryIDChanging(value)
				ReportPropertyChanging("CategoryID")
				_CategoryID = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("CategoryID")
				OnCategoryIDChanged()
			End Set
		End Property
		Private _CategoryID? As Global.System.Int32
		Partial Private Sub OnCategoryIDChanging(ByVal value? As Global.System.Int32)
		End Sub
		Partial Private Sub OnCategoryIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property QuantityPerUnit() As Global.System.String
			Get
				Return _QuantityPerUnit
			End Get
			Set(ByVal value As System.String)
				OnQuantityPerUnitChanging(value)
				ReportPropertyChanging("QuantityPerUnit")
				_QuantityPerUnit = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("QuantityPerUnit")
				OnQuantityPerUnitChanged()
			End Set
		End Property
		Private _QuantityPerUnit As Global.System.String
		Partial Private Sub OnQuantityPerUnitChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnQuantityPerUnitChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property UnitPrice() As Global.System.Decimal?
			Get
				Return _UnitPrice
			End Get
			Set(ByVal value? As System.Decimal)
				OnUnitPriceChanging(value)
				ReportPropertyChanging("UnitPrice")
				_UnitPrice = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("UnitPrice")
				OnUnitPriceChanged()
			End Set
		End Property
		Private _UnitPrice? As Global.System.Decimal
		Partial Private Sub OnUnitPriceChanging(ByVal value? As Global.System.Decimal)
		End Sub
		Partial Private Sub OnUnitPriceChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property UnitsInStock() As Global.System.Int16?
			Get
				Return _UnitsInStock
			End Get
			Set(ByVal value? As System.Int16)
				OnUnitsInStockChanging(value)
				ReportPropertyChanging("UnitsInStock")
				_UnitsInStock = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("UnitsInStock")
				OnUnitsInStockChanged()
			End Set
		End Property
		Private _UnitsInStock? As Global.System.Int16
		Partial Private Sub OnUnitsInStockChanging(ByVal value? As Global.System.Int16)
		End Sub
		Partial Private Sub OnUnitsInStockChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property UnitsOnOrder() As Global.System.Int16?
			Get
				Return _UnitsOnOrder
			End Get
			Set(ByVal value? As System.Int16)
				OnUnitsOnOrderChanging(value)
				ReportPropertyChanging("UnitsOnOrder")
				_UnitsOnOrder = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("UnitsOnOrder")
				OnUnitsOnOrderChanged()
			End Set
		End Property
		Private _UnitsOnOrder? As Global.System.Int16
		Partial Private Sub OnUnitsOnOrderChanging(ByVal value? As Global.System.Int16)
		End Sub
		Partial Private Sub OnUnitsOnOrderChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ReorderLevel() As Global.System.Int16?
			Get
				Return _ReorderLevel
			End Get
			Set(ByVal value? As System.Int16)
				OnReorderLevelChanging(value)
				ReportPropertyChanging("ReorderLevel")
				_ReorderLevel = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("ReorderLevel")
				OnReorderLevelChanged()
			End Set
		End Property
		Private _ReorderLevel? As Global.System.Int16
		Partial Private Sub OnReorderLevelChanging(ByVal value? As Global.System.Int16)
		End Sub
		Partial Private Sub OnReorderLevelChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=False), DataMemberAttribute()> _
		Public Property Discontinued() As Global.System.Boolean
			Get
				Return _Discontinued
			End Get
			Set(ByVal value As System.Boolean)
				OnDiscontinuedChanging(value)
				ReportPropertyChanging("Discontinued")
				_Discontinued = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Discontinued")
				OnDiscontinuedChanged()
			End Set
		End Property
		Private _Discontinued As Global.System.Boolean
		Partial Private Sub OnDiscontinuedChanging(ByVal value As Global.System.Boolean)
		End Sub
		Partial Private Sub OnDiscontinuedChanged()
		End Sub

		#End Region

		#Region "Navigation Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<XmlIgnoreAttribute(), SoapIgnoreAttribute(), DataMemberAttribute(), EdmRelationshipNavigationPropertyAttribute("NORTHWNDModel", "FK_Products_Categories", "Categories")> _
		Public Property Categories() As Categories
			Get
				Return (CType(Me, IEntityWithRelationships)).RelationshipManager.GetRelatedReference(Of Categories)("NORTHWNDModel.FK_Products_Categories", "Categories").Value
			End Get
			Set(ByVal value As Categories)
				CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Categories)("NORTHWNDModel.FK_Products_Categories", "Categories").Value = value
			End Set
		End Property
		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<BrowsableAttribute(False), DataMemberAttribute()> _
		Public Property CategoriesReference() As EntityReference(Of Categories)
			Get
				Return (CType(Me, IEntityWithRelationships)).RelationshipManager.GetRelatedReference(Of Categories)("NORTHWNDModel.FK_Products_Categories", "Categories")
			End Get
			Set(ByVal value As EntityReference(Of Categories))
				If (value IsNot Nothing) Then
					CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Categories)("NORTHWNDModel.FK_Products_Categories", "Categories", value)
				End If
			End Set
		End Property

		#End Region
	End Class

	#End Region

End Namespace
