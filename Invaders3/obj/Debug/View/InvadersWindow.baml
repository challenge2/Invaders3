   M S B A M L   `   `   `  ����D  @Invaders3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Invaders3.ViewModelInvaders3.ViewModel  5   	   #    Invaders3.View.InvadersWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7	viewmodel!clr-namespace:Invaders3.ViewModel     5   	   -   5          � Title$  InvadersWindow��5   	   $	��300��6    $	��400��6-    � 	Resources 5
      +  %Invaders3.ViewModel.InvadersViewModel   	viewModel4  .Invaders3.ViewModel.BooleanVisibilityConverter  visibilityConverter��%:   &	        &	        5   
   6&     5   
   6/   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $	��140 �6   �� 5      $��* �6   .+�5   
   �� 
���   �._�5      �� 
����+��6   5      �� 5   
   $��Right=�6   $��0,60,0,0q�61   .+�5      �� $��Right=�6/   $��0,0,15,0q�6K   ��6   �� *Score+6K   �� 5      
���   �$
��Auto��5      $��50��6$   $��Right=�60   ��5   *   �� *Lives+��5      �� 5      .R�5      �� $?��9C:\Users\user\source\repos\Invaders3\Invaders3\player.png��6    $��15��5   !   $��25��6-   5       5"      5#      �� 5%   
   -   5         ��Name$ playArea��5&      
����  �$��2q�5%   $    �� CornerRadius$ 10��68   $��5q�6J   
���   �$��1��5&      ._�5'      �� $��5q�5(   :   ��6   ��  �� Path$ Sprites���5)      �� 5*      .R�5+      �� 
���   �6!   5,      5.      5/      �� 51   
   $��Center=�6   $��Center=�62   y�52      �� *
GameOver+ �� 	Converter# [ .+�54      �� -   5        $��Start a new game��54      ���	#FFB52525$��30��55      $��135,50,153.286,60q�6>   56      �� 58   
   $��1��6   $��Paused��6!   $��Center=�6/   $��Arial Narrow)�59      $��60(�6.   
��� ���$��	ExtraBold"�5:   (   $��Italic$�6?   $��
120,0,0,60q�5;      y�5<      �� *Paused+# [ 5=      5>      