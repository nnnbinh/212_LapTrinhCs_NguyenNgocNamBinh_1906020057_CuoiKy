   M S B A M L   `   `   `  ����I  ETetrisGameVIDO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TetrisGameVIDOTetrisGameVIDO  5   	       TetrisGameVIDO.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TetrisGameVIDO     5   	   -   5          � Title$  
MainWindow��5   	   $	��700��6   $
��1000��6)   $	��600��5	   	   $	��600��6   
�������$��Segoe UI Light)�5   	   $��28(�6%   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   ��5   
   �� 5        �� ImageSource$  Assets/backgroundimage.png��6   .+�5#   
   (� $��1��6   $��1��5$      $��0,0,0,20q�5%      .��5&      �� -   5         ��Name$ 
GameCanvas��5&      ���#101010$	��250��5(      $	��510��5)      $
}�True��5*      5+      5,      �� 50   
   -   5         ��Name$ 	ScoreText��50      $��0��51      $��Score: ��52      $��351,10,351,0q�53       �� TextAlignment$ Center=�54      $��3��6+   $��37��6?   $	��Top=�6K   �� 56   
   $��1��6   $��0��59      $��Center=�5:      $��Right=�5;      .+�5<      �� $
��Hold��6   $ Center=�5=      �� 5?      -   5         ��Name$ 	HoldImage��5?      $��20q�5@      $	��125��5A      5B      �� 5H   
   $��1��6   $��2��5I      $��Center=�5J      $
��Left=�5K      .+�5L      �� $
��Next��6   $ Center=�5M      �� 5O      -   5        $ 	NextImage��5O      $��20q�5P      $	��125��5Q      5R      � 5T   
   -   5         �Name$ GameOverMenu��5T      ���	#CC000000$��2��5V      $��3��5W      $y�Hidden=�5X      .+�5Y      �� $��Center=�6   $��Center=�5Z      .+�5[      �� $��	Game Over��6   $��48(�5\      $ Center=�5]      �� 5_      -   5        $ FinalScoreText��5_      $��Score: ��5`      $��36(�5a      $ Center=�5b      �� 5c      $��Your name: ��6   
�������6.   �� 5d      -   5        	 ��Name$	 txtName��5d      $��	Anonymous��6+   �� 5f      -	   5        $��
Play Again��5f      
������$��0,20,0,0q�5h      $��5q�5i      5j      5k      5l      �� 5m   
   $��1��5n      $	��Top=�5o      $��2��6-   $	��246��6A   $��	302,0,0,0q�6N   $��2��6a   .+�5p      �� $��	HighScore��6   $ Center=�5q      $��Bottom=�6/   $��Center=�6J   �� 5r      -
   5        $ txtHighScore��5r      $ Center=�5s      $��3��60   $	��208��6D   $��Center=�6Q   $��10��6n   $��24(�6�   5u      5v      5x      