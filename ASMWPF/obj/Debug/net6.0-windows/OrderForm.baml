   M S B A M L   `   `   `  ����A  =ASMWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ASMWPFASMWPF  5   	       ASMWPF.OrderForm   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:ASMWPF     5   	     � Title$  	OrderForm��5   	   $	��410��6   $	��480��6(    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � .+�5   
   �� $��Deliver to:��6   $��10,29,402,0q�6&   $	��Top=�6;   $
��Bold"�6S   ���	#FF8C8C8C6e   �� 5   
   -   5         ��Name$ 	tbAddress��5      $��10,52,10,271q�6%    �� TextWrapping$
 Wrap=�6;   $�� ��6O   ���	#FFD4D4D46W   �� 5   
   $�� ��6   $��10,5,0,0q�6   
�������
���   �$��19��6U   $	��Top=�6a   $
��Left=�6y   $��34��6�   ��5      �� 5      .R�5      �� $��/images/arrow.png��6   5      5      �� 5   
   $��Center=�6   $	��100��61   $��	0,-71,0,0q�6>   ���	#FFD8D8D8$	��Top=�6d   $	��554��6|   �� 5   
   $��Checkout��6   $��189,0,189,0q�6#   $��16(�68   $��29��6F   $	��Top=�6R   �� 5   
   $
��Left=�6   $	��399��6/   $��-16,128,0,0q�6<   
�������$	��Top=�6`   $	��533��6x   ���	#FFD8D8D86�   �� 5   
   $��Center=�6   $��26��61   $��	0,134,0,0q�6=   
�������$	��Top=�6_   $	��480��6w   
�������6�   �� 5   
   $��Your Order:��6   $��	8,139,0,0q�6&   $	��Top=�69   $
��Bold"�6Q   ���	#FF8C8C8C$
��Left=�6z   $��83��6�   �� 5   
   -   5         ��Name$ lbData��5      $��0,160,0,123q�6M   
�������6b   �� 5   
   $��-25,276,0,0q�6   ���	#FFD8D8D8
�������$
��Left=�6I   $	��516��6d   $��34��6p   $	��Top=�6|   �� 5   
   $�� ��6   $��0,284,435,0q�6   
�������
���   �$	��Top=�6X   $��18��6p   $��Right=�6|   $��27��6�   ��5      �� 5      .R�5      �� $��/images/note.png��6   5      5!      �� 5"   
   -   5        $ tbNote��5"      $
��Left=�6"   $��
50,284,0,0q�6=   $
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��420��6�   ��6�   Z� .��6�   ��5#      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5$   -   �� 6   6sys&clr-namespace:System;assembly=mscorlib     6-    �� 
TargetType" ��6    �� 	Resources 5%         CueBannerBrush j� 
AlignmentX	 j� 
AlignmentY
 j� Stretch !� Visual��%�   &	        !� 5&      $
 Left=�6=   $	 Center=�6O   $

 None=�6c    5'      �� 5(   "   $��Any note for store?��6(   
�������6F   5*      5+       �� Triggers 5,      P� 5-       P� Property � �� �� Empty P� Value# Z 62   . �5.      ��  �� Property � �� �� Value# [  6;   5/      P� 50       � �� 62   Z� . �51      ��  � ��# [  6;   52      P� 53       �@J�IsKeyboardFocused$
 True��6?   . �54      ��  � ��
 �����6;   55      57      .��58      59      �� 5:   
   $
��Left=�6   $��	-44,0,0,5q�6/   $	��590��6B   
�������$��47��6[   $��Bottom=�6g   �� 5;   
   $��
Money here��6   $
��Left=�6%   $��
115,0,0,17q�6@   $	��155��6T   $��30��6`   $��Bottom=�6l   $��16(�6�   $
��Bold"�6�   �� 5<   
   $��Total:��6   $
��Left=�6!   $��	58,0,0,20q�6<   $��26��6O   $��Bottom=�6[   $��14(�6v   �� 5=   
   $��Order��6   $
��Left=�6!   $��
330,0,0,17q�6<   $��Bottom=�6P   $��88��6k   $��25��6v   5>      5?      