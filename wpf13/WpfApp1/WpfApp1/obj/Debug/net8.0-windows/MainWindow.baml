   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��300��6)    � 	Resources 5	       �� 
TargetType   
btTemplate �� CornerRadius��%�   &	        �� 5
   
   " ��6   .R�5      �� $ 25��6   #��z��5      #��z��5      #��z��5      #��z��5      #��z��5      ._�5      �� #��z��6!   #��z��5   !   #��z��5   !   #��z��5   !   5      5      5      .��5      � .+�5   
   �� -   5         ��Name$ myButton��5      $��Привет��6#   $��40��64   $	��100��6@   
���������5      �� 5      " ��6"   .R�5      ��  ��Name$ buttonBorder��6   $ 25��63   #��z��5      #��z��5      #��z��5      #��z��5       #��z��5!      ._�5"      �� #��z��6)   #��z��5#      #��z��5$      #��z��5%      5&       �� Triggers 5'      P� 5(       P� Property �@J�IsMouseOver P� Value$
 true��69   . �5)      �� 	 �� Property	 � ��
 �� Value$

 Bold"�6;   5*      P� 5+       � ��$
 true��67   . �5,      ��  �� 
TargetName$ buttonBorder��6%   	 � ��

 �����6U   �� 5-      $ buttonBorder��6%   	 � ��

 ��  �6V   5.      P� 5/       � {�$ false��67   . �50      �� 	 � ��

 �����6;   �� 51      $ buttonBorder��6%   	 � ��

 �����6U   52      54      56      57      58      