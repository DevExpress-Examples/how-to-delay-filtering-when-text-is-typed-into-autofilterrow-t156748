# How to delay filtering when text is typed into AutoFilterRow


<p>To make a delay in filtering with AutoFilterRow, it is necessary to create an attached DelayTime property and its default value to 0. When the DelayTime property value is changed and a new value is more than the default one, the editor’s EditValuePostDelay is set to the DelayTime property value and the editor’s EditValuePostMode is changed from Immediately to Delayed.</p>

<br/>


