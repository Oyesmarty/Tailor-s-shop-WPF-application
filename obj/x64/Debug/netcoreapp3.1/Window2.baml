   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   D @FluentWPF, Version=0.9.0.1, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF 5	   	       WpfApp1.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   ?fw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF  5	   	   )  #SourceChord.FluentWPF.AcrylicWindow    Enabled$
  True��5
   	      ExtendViewIntoTitleBar$ False��5   	   $	��600��6:   $
��1080��6G    � WindowStyle$
 None=�6T    � 
ResizeMode$ NoResize=�6g    � WindowStartupLocation$ CenterScreen=�6}   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��300* �6   �� 5      $
��800* �6   .+�5   
   � *  $SourceChord.FluentWPF.PointerTracker   Enabled$
 True��6   ���	#01FFFFFF.+�5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        
���������5   0   Z� ��6F   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�62   
�������6C   5      �� 5      $��Logout��6    $��12(�6.   $��10q�6<   $��Center=�6H   5      �� 5      -   5        $��1q�5      
���   �$��53��6e   $	��294��6q   ��6O   Z� .��5      �� $
��Home��6    $��16(�6,   $
��Bold"�6:   
�������$��Center=�6_   5      �� 5      $��System Entries��6   $��15q�62   $��DemiBold"�6>   �� 5      
�������$��15(�6.   
�������.@�5      �� -   5        $��1q�5   #   .��5       �� $ 
Horizontal=�6&   .+�5!        $	 Add=�66   $��15q�6A   �� 5"      $	��Add��6(   $��Center=�63   5#      5$      �� 5%      -   5        $��1q�5%   #   .��5&      �� $ 
Horizontal=�6%   .+�5'        $ Delete=�66   $��15q�6D   �� 5(      $��Delete��6(   $��Center=�66   5)      5*      �� 5+      $��1q�6#   .��5,      �� $ 
Horizontal=�6%   .+�5-        $
 Edit=�66   $��15q�6B   �� 5.      $��Modify��6(   $��Center=�66   5/      50      �� 51      $��1q�6#   .��52      �� $ 
Horizontal=�6%   .+�53        $ BubbleChart=�66   $��15q�6I   �� 54      $
��View��6(   $��Center=�64   55      56      57      59      5:      � 5;   
   $��1��6   
�������.+�5<       � -   5        	  �Name$
	 Main��5<      
  � NavigationUIVisibility$
 Hidden=�6"   5=      5>      5?      