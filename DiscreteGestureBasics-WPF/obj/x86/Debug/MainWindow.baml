   M S B A M L   `   `   `  ����T  PDiscreteGestureBasics-WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:Microsoft.Samples.Kinect.DiscreteGestureBasics.Microsoft.Samples.Kinect.DiscreteGestureBasics  5   	   ?    9Microsoft.Samples.Kinect.DiscreteGestureBasics.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Nlocal<clr-namespace:Microsoft.Samples.Kinect.DiscreteGestureBasics     5   	   -   5          � Title$  Discrete Gesture Basics��5   	   $	��650��5   	   $	��750��6    � WindowStyle$
 None=�5   &    � 	Resources 5         MediumGreyBrush �� Color  KinectPurpleBrush  KinectBlueBrush �� DataTypeF   @Microsoft.Samples.Kinect.DiscreteGestureBasics.GestureResultView � RowDefinitions �� StringFormat��%�  &	        &	 #     &	 F     (�� i     5      *, +)�� 5	   
   $ 	#ff6e6e6e��62   �� 5
   
   $ 	#ff52318f��64   �� 5   
   $ 	#ff00BCF2��62   �� 5   
   "  6   .R�5      � $
��Auto��6   $��5q�6    ��6+   �� *	BodyColor+ 5      �� 5      $
��Auto �6$   �� 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��Stretch=�6   $��14(�6u   $��Segoe UI)�6�   $��SemiBold"�6�   $��5q�6�   ��6:   �� *	BodyIndex+$ Body Index: {0}��6�   �� 5      $��Uniform=�67   $��1��6I   $��5q�6V   ��6   �� *ImageSource+6V   �� 5      $��18(�6R   $��Segoe UI)�6`   $��SemiBold"�6v   $��2��6�   $��5 5 0 0q�6�   ��6   �� *
Detected+$ Seated: {0}��6�   �� 5      $��18(�6X   $��Segoe UI)�6f   $��SemiBold"�6|   $��3��6�   $��5 0 0 0q�6�   ��6   �� *
Confidence+$ Confidence: {0}��6�   5      5      5      .��5      � $��	10 0 10 0q�6    5   
   �� 5       $
��Auto �6   �� 5!      $��* �6   �� 5"      $
��Auto �6   .+�5%   
   �� $��0��6   $��Images\Logo.png��6   $
��Left=�66   $
��Fill=�6Q   $��32��6`   $��81��6l   $��0 10 0 5q�6w   �� 5&   
   $��0��6   $��0 0 -1 0q�6!   $��Right=�63   $��Bottom=�6O   #��[  6j   $��Segoe UI)�6�   $��18(�6�   MSA Project6�   �� 5'   
   $��0��6   $��Images\Status.png��6   $
��None=�68   $��Center=�6G   $��0 0 0 5q�6d   � 5)   
   -   5         �Name$ contentGrid��5)      $��1��6$   $��1,5,-1,1q�61   $��2��6C    � ColumnDefinitions 5*      �� 5+      �� 5,      $��0* �6#   �� 5-      $
��360* �6#    5/      �� 50      $��7* �6    �� 51      $
��272* �6    �� 52      $��0* �6    .+�55      �� 	 �� Orientation$	 Vertical=�6   $��2��60   $��21,10q�6@   $��Center=�6O   $��Center=�6l   $	��524��6�   $��1��6�   $	��678��6�   .+�56      (� -   5        
 (�Name$
 kinectBodyViewbox��56      .��57      �� $��UniformToFill=�6;   ��6   �� *ImageSource+6;   58      �� 59      $����This program can track up to 6 people simultaneously. Stand in front of the sensor to get tracked. Sit down to trigger the 'Seated' gesture.��6   $
��Wrap=�6�   $��5 10 5 5q�6�   #��[  6�   $��Segoe UI)�6  $��14(�6  5:      5;      �� 5=   
   -   5        $��	statusBar��5=   ?   $��2��6   $��Stretch=�6!   $��Bottom=�6P   
�������#��[  6~   .@�5>      �� ��6   �� *
StatusText+5?      5@      5A      