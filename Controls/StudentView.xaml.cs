using Projekt.Models;
using Projekt.Views;

namespace Projekt.Controls;

public partial class StudentView : ContentView
{
    readonly private MainPage _parentPage;

    public StudentView()
    {
        InitializeComponent();
    }

    public StudentView(MainPage parentPage, Student student)
    {
        InitializeComponent();
        BindingContext = student;
        _parentPage = parentPage;
    }

    private void RemoveButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Student student)
        {
            _parentPage.RemoveStudent(student);
        }
    }

    private void PresentCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (_parentPage != null && BindingContext is Student student)
        {
            student.IsPresent = e.Value;
            _parentPage.UpdateJSON();
        }
    }
}