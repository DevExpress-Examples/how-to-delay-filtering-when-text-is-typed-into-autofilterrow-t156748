Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid

Namespace AutoFilterRowPostDelay
    Public Class PostDelayHelper
        Public Shared DelayTimeProperty As DependencyProperty = DependencyProperty.RegisterAttached("DelayTime", GetType(Integer), GetType(PostDelayHelper), New PropertyMetadata(0, New PropertyChangedCallback(AddressOf DelayTimeChanged)))

        Public Shared Sub SetDelayTime(ByVal d As DependencyObject, ByVal value As Integer)
            d.SetValue(DelayTimeProperty, value)
        End Sub

        Public Shared Function GetDelayTime(ByVal d As DependencyObject) As Integer
            Return DirectCast(d.GetValue(DelayTimeProperty), Integer)
        End Function

        Public Shared Sub DelayTimeChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            If DirectCast(e.NewValue, Integer) >= 0 AndAlso TypeOf d Is GridColumn Then
                AddHandler TryCast((TryCast(d, GridColumn)).View, GridViewBase).ShownEditor, Sub(sender As Object, args As EditorEventArgs)
                                                                                                 If args.RowHandle = GridControl.AutoFilterRowHandle AndAlso args.Column.Equals(TryCast(d, GridColumn)) Then
                                                                                                     TryCast(args.Editor, BaseEdit).EditValuePostDelay = GetDelayTime(d)
                                                                                                     TryCast(args.Editor, BaseEdit).EditValuePostMode = PostMode.Delayed
                                                                                                 End If
                                                                                             End Sub
            End If
        End Sub
    End Class
End Namespace
