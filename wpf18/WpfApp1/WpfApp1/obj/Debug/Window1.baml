   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��300��6)    � Triggers 5	      :� 5
   
    :� RoutedEvent$ Button.Click��6   [�5      �� 5      .��5      ��  g� DesiredFrameRate$ 60X�6!   .��5      W�  �� 
TargetName$
 ball��6*    �� TargetProperty$ (Canvas.Bottom)�6G    W� From$ 0X�5   "   	 W� To$	 160X�6+    g� AutoReverse . 	 g� Duration$	 0:0:2.5D�6G   
 g� RepeatBehavior$
 Forever��6Z    g� DecelerationRatio$ 1Q�5   "   5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   �� 
�������.+�5      A� -   5        $
��ball��5      
���   �$��20��62   $��20��6=    �� Left$	 130��6I    �� Bottom$ 0��6[   ��5      
� 5       
� RadiusX$ 1Q�6*    
� RadiusY$ 1Q�66    
� GradientOrigin$ 0.3, 0.3&�6B   .��5      �  � Color$ White��6'    � Offset$ 0Q�65   � 5       $
 Blue��6'   $ 1Q�64   5!       5#      :� 5$      $ Window.Loaded��6#   .[�5%      �� .��5&      �� .��5'   "   �� $! Fill.GradientStops[1].Color�61   	 �� To$ YellowX�5(      $	 0:0:8D�6)    . $
 Forever��5)      5*      5+      5,      5.      5/      �� 50   
   -   5         ��Name$ helloButton��50      
�������$��70��69   $��25��6D   $��Кнопка��6P   ��51      �� 52      -   5        buttonColor�� �� Color$ Black��52   7    54      :� 55      $ Loaded��6   [�56      �� 57      .��58      �� .��59   "   W� $ Width�62   $ helloButton��6T   $ 80X�5:      $	 150X�6)    . $
 0:0:10��6F   $	 0:0:2D�6^   W� 5;   "   $ Height�62   $ helloButton��6U   $ 30X�5<      $	 100X�6)    . $
 0:0:10��6E   $	 0:0:2D�6]   �� 5=   "   $ buttonColor��61   $ Color�6U   $	 RedX�5>   T    . $
 0:0:10��5?   2   $	 0:0:2D�6J    �� From 5>      ��  �� ElementName$ buttonColor�� �� Path$ Color�5?   J   5@      5A      5C      5E      5F      5G      