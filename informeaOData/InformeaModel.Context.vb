﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class InformeaEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=InformeaEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Contacts() As DbSet(Of contact)
    Public Overridable Property treaties_Contacts() As DbSet(Of contacts_treaties)
    Public Overridable Property CountryReports() As DbSet(Of country_reports)
    Public Overridable Property title_CountryReports() As DbSet(Of country_reports_title)
    Public Overridable Property Meetings() As DbSet(Of meeting)
    Public Overridable Property description_Meetings() As DbSet(Of meetings_description)
    Public Overridable Property title_Meetings() As DbSet(Of meetings_title)
    Public Overridable Property Sites() As DbSet(Of site)
    Public Overridable Property name_Sites() As DbSet(Of sites_name)

End Class
