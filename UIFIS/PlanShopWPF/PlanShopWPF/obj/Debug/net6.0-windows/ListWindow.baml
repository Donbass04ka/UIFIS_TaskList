   M S B A M L   `   `   `  ����F  BPlanShopWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PlanShopWPFPlanShopWPF  5   	       PlanShopWPF.ListWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:PlanShopWPF     5   	     � Title$  
ListWindow��5   	   $	��523��6   $	��929��6)   .��5	      � $��0,0,0,22q�6   .+�5
   
   �� -   5         ��Name$ CreatePunctBtn��5
      $!��Добавить пункт��6)   $��16,10,465,437q�6B   6Y   �� 5   
   -   5        $ ExitBtn��5      $��
Назад��6"   $��482,10,16,437q�62   6I   &   System.Windows.Controls.DataGrid  5   
   -   5        $��ListGrid��5         AutoGenerateColumns$ False��6#      CanUserAddRows$ False��6?      
IsReadOnly$
 True��6V   $��
5,48,5,-13q�6h      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$# Название пункта��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Title+6X   5      5      5      