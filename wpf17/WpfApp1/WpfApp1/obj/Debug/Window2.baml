   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Window2   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��200��6   $	��300��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��25��6    � Minimum$ 0Q�6    � Maximum$	 360Q�6)    � Value 5      ��  �� ElementName$ rotate�� �� Path$ Angle�'� 5   
   $��1��6    '� Camera 5      =� 5       � Position$ 0.5,0.5,3.51�6$   	 � LookDirection$	 0,0,-3.55�6;   x�5      g� 5      
 g� Content
 5      t� 5       �� Color$ White��6+    t� 	Direction$ -1,-1,-25�69   5      g� 5      
 5      � 5       � Geometry 5      k� 5   "    k� 	Positions! �    k� TriangleIndices. �$      5        � Material 5$      u� 5%   "    u� Brush
 ��  �62   5'       g� 	Transform 5)      �� 5*       �� Rotation 5+      �� 5,   "   -   5        
rotate�� �� Axis$ 0 1 05�5,   F   5.      50      52      53      54      