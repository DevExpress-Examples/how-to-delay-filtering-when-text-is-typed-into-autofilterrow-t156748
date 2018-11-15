<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/AutoFilterRowPostDelay/Data.cs) (VB: [Data.vb](./VB/AutoFilterRowPostDelay/Data.vb))
* [MainWindow.xaml](./CS/AutoFilterRowPostDelay/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/AutoFilterRowPostDelay/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/AutoFilterRowPostDelay/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/AutoFilterRowPostDelay/MainWindow.xaml.vb))
* **[PostDelayHelper.cs](./CS/AutoFilterRowPostDelay/PostDelayHelper.cs) (VB: [PostDelayHelper.vb](./VB/AutoFilterRowPostDelay/PostDelayHelper.vb))**
<!-- default file list end -->
# How to delay filtering when text is typed into AutoFilterRow


<p>To make a delay in filtering with AutoFilterRow, it is necessary to create an attached DelayTime property and its default value to 0. When the DelayTime property value is changed and a new value is more than the default one, the editor’s EditValuePostDelay is set to the DelayTime property value and the editor’s EditValuePostMode is changed from Immediately to Delayed.</p>

<br/>


