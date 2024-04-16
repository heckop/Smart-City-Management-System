﻿Imports System.Data.SqlClient
Imports SmartCityMgmtSystem.Ed_Coursera_Handler
Public Class Ed_ECourseManage_Stats
    Dim handler As New Ed_Coursera_Handler()
    Private Sub Ed_Stud_Coursera_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim courses As Course() = handler.GetApprovedCoursesWithCounts()

        ' Create Ed_ECourseStatDropItem objects and set properties
        Dim labels As Ed_ECourseStatDropItem() = New Ed_ECourseStatDropItem(courses.Length - 1) {}

        For i As Integer = 0 To courses.Length - 1
            labels(i) = New Ed_ECourseStatDropItem()
            labels(i).CourseID = courses(i).CourseID
            labels(i).Label6.Text = courses(i).Name ' Set course name
            labels(i).Label1.Text = courses(i).TeacherName ' Set instructor name
            labels(i).Label2.Text = courses(i).Institution ' Set affiliation
            labels(i).Label4.Text = courses(i).Rating.ToString() ' Set rating
            labels(i).Label8.Text = courses(i).EnrolledStudents
            labels(i).Label7.Text = courses(i).CompletedStudents
        Next

        ' Add Ed_ECourseStatDropItem objects to the FlowLayoutPanel
        For Each edCourseListItem As Ed_ECourseStatDropItem In labels
            FlowLayoutPanel1.Controls.Add(edCourseListItem)
        Next
    End Sub


End Class