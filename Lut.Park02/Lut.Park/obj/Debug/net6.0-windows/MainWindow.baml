   M S B A M L   `   `   `  ����C  ?Lut.Park, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Lut.ParkLut.Park  5   	       Lut.Park.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Lut.Park     5   	   -   5        $��Microsoft YaHei)�5      $��
ExtraLight"�6(     � Title$*  $公园环境空气质量监测系统��5	   	   $	��650��6   $
��1200��6+    � WindowStyle$
 None=�5
   	    � AllowsTransparency$
 True��6    � 
ResizeMode$ CanResizeWithGrip=�66    � WindowStartupLocation$ CenterScreen=�6U    � 	Resources 5       �� MergedDictionaries �� Source �� 
TargetType   Key	 �� Property
 �� Value �� 
TargetType �� CornerRadius � ColumnDefinitions
 � Tag �� Triggers P� Property P� Value�� 5   
    5      �� 5      $8 2/Lut.Park;component/Assets/Styles/ButtonStyle.xaml?�6%   �� 5      �� 5      " 	�6   NavTabButtonStyle  .�5      �� 	 � ��$
 15(�65   �� 5      	 � ��
 �#DDD67   �� 5      	 � ��$

 10,5q�64   �� 5      	 � ��$	
 5,0q�63   �� 5      	 � ��

 ���� 67   �� 5      	 � ��
 64   �� *TabChangedCommand+�� 5      	 � ��
 5      �� 5   "   " 	�62   .R�5   &   �� #��z��6-   $ 5,5,0,0��6W   ._�5   *   �  5   .   �� 5   2   $
��auto �6C   �� 5    2   .+�5"   .   �� #��z 68   $��Assets/Fonts/#iconfont)�6U   $��14(�5#   ,   $��Center=�6:   $��Center=�6U   $��10,0,0,0q�6r   �� 5$   .   $��1��6?   #��z��6O   #��z��5%   3   #��z��5&   3   5'   +   5(   '   5)   #   5+       5,      P� 5-       �@d�	IsChecked$
 TrueY�6;   . �5.   "   �� 	 � ��

 �����6?   �� 5/   "   	 � ��
 �#FF68006?   50      52      53      %
   '	�       55      .��58      � ��59   
   
� 5:       
� Center$ 0.5,0.7&�6"    
� GradientOrigin$ 0.5,0.7&�63    
� RadiusY$	 0.8Q�6L    
� RadiusX$	 0.8Q�6Z   .��5;      �  � Color$ #FFA4B3��6   � 5<      $ #FFA4B3��6    � Offset$ 0.952Q�6/   � 5=      $ 	#FF96AAD4��6   $ 0.162Q�61   5>       � RowDefinitions 5@   
   �� 5A      $	��100 �6   �� 5B      .+�5D   
   � .+�5E      �� $��55��6   $��50��6    $��	10,0,20,0q�6,   $
��Left=�6?   ��5F      �� 5G       �� ImageSource$ /Assets/Images/logo.png��6!   5I      �� 5J      $��Center=�6   .+�5K      �� $*��$公园环境空气质量监测系统��6   
�������$��25(�6C   $��85,0,0,0q�6Q   �� 5L      $��45��6   
������ ���#FF6800$��0,0,0,1q�6T   $
��10,0q�5M      ._�5N      ��  �� Orientation$ 
Horizontal=�6!   $��Bottom=�6:   $��70,0,0,0q�6U   .+�5O      	� $��系统监控��6&   $	 ��65     NavTabButtonStyle#��[ 6D    d� 	IsChecked$
 TrueY�6o   $!��Lut.Park.View.SystemMonitor��5P   &   	� 5Q      $��实时曲线��6&   $	 ��65   #��[ 6D   $ ��Lut.Park.View.RealtimeData��5R   &   	� 5S      $��历史数据��6&   $	 ��65   #��[ 6D   $��Lut.Park.View.StoredData��5T   &   	� 5U      $��控制策略��6&   $	 ��65   #��[ 6D   $��Lut.Park.View.Control��5V   &   5W      5X      5Y      �� 5[      $ 
Horizontal=�6   $	��Top=�62   $��Right=�6J   .+�5\      �� $	����6     IconButtonStyle#��[ 6,   $��14(�6U   �� 5]      $	����6   #��[ 6,   $��10(�6U   �� 5^      -   5        $	����5^      #��[ 6,   6U   5_      �� 5`      $ 
Horizontal=�6   $��Bottom=�62   $��Right=�6M   $��20,15q�5a      .+�5b      �� $��MY1027��6   
�������$��Center=�6>   $
��10,0q�6Y   �� 5c      $��30��6   $��30��6$   $ 15��60   $��1q�6B   
������� J� Effect 5d      3  -System.Windows.Media.Effects.DropShadowEffect  5e         
BlurRadius$ 5Q�6+      ShadowDepth$ 0Q�6:      	Direction$ 0Q�6J       Opacity$	  0.4Q�6X   !   Color$! White��6f   ��5g      �� 5h      $ Assets/Images/user.png��6%   5j      5k      5m      �� 5n   
   $��1��6   ��6&   �� *MainContent+5p      5q      