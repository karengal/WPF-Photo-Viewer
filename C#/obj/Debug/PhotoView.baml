   M S B A M L   `   `   `  ����  	SDKSample&     SDKSamples.ImageSample.PhotoView   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      -   5          � Title$  Photo Viewer��5      .��5      � -   5        $��PhotoViewerLayout��5      $��10q�6    � ColumnDefinitions 5      �� 5	   
    � RowDefinitions 5      �� 5   
   $��* �6   �� 5   
   $
��Auto �6   .+�5      �� $��0��6   $��0��6   $��Stretch=�5      $��Stretch=�6-    �� CornerRadius$ 4��5      ���	#44000000z�5   
   T� 5       T� X$ 5Q�6    T� Y$ 5Q�6%    J� BitmapEffect 5   
   �� 5       �� Radius$ 8Q�6   5   	   �� 5      $��0��6   $��0��6    �� Padding$ 4q�6,   $��4q�68   
����������	#22000000$��1q�5   :   ._�5      �� -   5        $��ViewedPhoto��5   3   5!      5#      �� 5&      $��0��6   $��1��6   $ 4q�6,   ._�5'   
   �� 	 �� Orientation$	 
Horizontal=�6   .+�5(      �� -   5        $��ViewedCaption��5(      $
��Left=�6'   �� 5)      -   5        $
��Crop��5)       �� 5*      -   5        $��Rotate��5*   "   �� 5+      -   5        $��BlackAndWhite��5+   )   5,      5-   	   �� 5.   
   -   5        $��Label1��5.      
 �� ContentStringFormat$
 Num of images: {0}��6   ��5/      �� 50       �� Path$ Count�6    �� Mode$ OneWay=�6'    �� UpdateSourceTrigger$ Default=�65   52      53      54      