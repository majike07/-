   M S B A M L   `   `   `  ����C  ?Lut.Park, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Lut.Park.ViewLut.Park.View  5          Lut.Park.View.Control   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Lut.Park.View     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      .+�5   
   �� $��10,172,-10,-172q�6   .+�5      �� $��5q�6   $��串口连接��6"   .��5      �� 
����ح� �� Padding$ 7q�60   $��5q�6<   ._�5      �   5      �� 5      $
��Auto �6/   6>   �� 5      61   �� 5      $
��Auto �6/   6>   �� 5      $
��Auto �6/   6>   .+�5      �� $��7q�6    .��6,   串口列表:63   �� 5      -   5        $��SerialPortNamesCmbBox��5   #   $��1��6@   $��5q�6P   6]   �� 5      -   5        $��
RefreshBtn��5   !   $��2��63   $��5q�6C   $��7,0,7,0q�6N   
������$	��100��5   5   .��6Z   	Refresh6c   �� 5      -   5        $��SerialPortConnectBtn��5   !   $��3��6=   $��5q�6M   $��7,0,7,0q�5      
����� �$	��100��6A   .��5   @   	Connect6I   5       5!      5"      �� 5$      -   5        $��LedControlPanel��5$      ${�False��60   .+�5%      �� $	��LED��6   $��5q�6(   .��5&      �   5'      �� 5(      $
��Auto �6/   6>   �� 5)      61   .+�5,      �� $��0��6#   $��1q�63   $��5q�6G   $��Switch��6R   .��5-      � 
����ح�$��5q�6:     5.   "   �� 5/   &   69   �� 50   &   69   .+�52   "   �� -   5        $��	LedOffBtn��52   )   
�������$��40��53   %   $��7q�60   .��6T   OFF6Y   �� 54   "   -   5        $��LedOnBtn��54   )   $��40��6:   $��7q�6E   $��1��6Q   
�������.��55   R   ON6V   56      57      �� 59      $��1��6#   $��1q�63   $��5q�6G   $��
Brightness��6R   .��5:      � 
����ح�$��5q�6:     5;   "   �� 5<   &   69   �� 5=   &   $
��Auto �67   6F   .+�5@   "   �� -   5        $��SliderBrightness��5@   )   $��5q�6A    � Minimum$ 0Q�6L    � Maximum$	 255Q�5A   %    �� TickPlacement$ TopLeft=�63   5B   T   �� 5C   "   -   5        $��LblSliderBrightness��5C   (   $��1��6C   $��40��6S   6`   5D      5E      5F      5G      5H      5I      5J      5K      