   M S B A M L   `   `   `  ����I  Etodolist.views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:todolist.viewstodolist.views  5   	   "    todolist.views.AddNoteWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:todolist.views     5   	     � Title$  New Note��5   	   $	��450��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�63   .��5	      � .+�5   
   �� $��Create a New Note��6   $��Center=�5      $��0,20,0,0q�5      $��24(�5      $
��Bold"�5      ���#3335      �� 5   
   $��	New Note:��6   $
��Left=�5      $��	10,70,0,0q�5      $	��Top=�5      $��16(�5      $��Normal"�5      ���#5555      �� 5   
   -   5         ��Name$ NoteContent��5      $��Center=�5      $��10,100,10,0q�5       �� TextWrapping$
 Wrap=�5      $	��Top=�5       $	��760��5!      $	��200��5"      $��14(�5#      ���#ccc$��1q�5%      �� 5(   
    �� Orientation$ 
Horizontal=�6   $��Right=�5)      $��
0,320,10,0q�5*      $	��Top=�5+      .+�5.      �� -   5        $
��Save��5.      $��80��5/      $��35��50      $��10,0,0,0q�51      $��Verdana)�52       � Cursor$
 Hand��53      ���#4CAF50
����������#4CAF50$��2q�57       � ToolTip 59      _� 5:      $��Click to save the note��6   5<      �� 5?      -   5        $��Cancel��5?      $��80��5@      $��35��5A      $��10,0,0,0q�5B      $��Verdana)�5C      $
 Hand��5D      ���#F44336
����������#F44336$��2q�5H       5J      _� 5K      $*��$Click to cancel and close the window��6   5M      5N      5O      5P      