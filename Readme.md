<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# OBSOLETE: How to create LayoutControlItem's with predefined quantity rows and columns at runtime


<p><strong>Starting with version 16.2, LayoutControl provides the new mode </strong><a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument114044"><strong>Table Layout Mode</strong></a><strong>. It is a two-dimensional grid that consists of cells formed by a set of rows and columns. Each layout item is arranged in table cells according to its row and column indexes and span values.</strong></p>
<p><strong> </strong></p>
<p>This sample illustrates how to create layout items at runtime. Layout items are created in the BeginInit/EndInit block. This improves performance. If you specify item bounds yourself, and place your code in the BeginInit/EndInit block, the LayoutManager doesn't recalculate item bounds inside this block, but you must make sure that you don't have any gap between your layout items.The AddRange method was used to add a layout item array.</p>

<br/>


