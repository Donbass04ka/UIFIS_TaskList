   M S B A M L   `   `   `  ����F  BPlanShopWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PlanShopWPFPlanShopWPF  5   	       PlanShopWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:PlanShopWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ White��6    � Offset$ 0Q�6-   � 5      $ 	#FFCACACA��6   $ 0.837Q�61   5       � ColumnDefinitions 5   
   �� 5      $
��103* �6   �� 5      $	��97* �6    � RowDefinitions 5   
   �� 5      $	��29* �6   �� 5      $	��24* �6   �� 5      $	��25* �6   �� 5      $	��38* �6   �� 5      $	��29* �6   .+�5   
   �� $��
203,38,0,0q�6   $
��Left=�6(   $	��Top=�6C   $��1��6[   $��
Логин��6h   $��16��6u   $��34��6�    J� RenderTransformOrigin$ 0.434,-1.24&�6�   �� 5   
   $��
199,22,0,0q�6   $
��Left=�6(   $	��Top=�6C   $��2��6[   $��Пароль��6h   $��16��6v   $��41��6�   6�   �� 5   
   -   5        $��	LoginTBox��5   �   $	��Top=�6   $��245,36,194,0q�6*   $��2��6@   $��30��6T   ���	#FFD2D2D2���	#FFE0E0E0$��1��6�   G� 5   
   -   5        $��PasswordPBox��5   �   $	��Top=�6   $��245,14,194,0q�6.   $��2��6D   $��2��6X   $��31��6e   ���	#FFCED8E0���	#FFE0E0E06�   �� 5!   
   -   5        $��EnterBtn��5!   �   $��2��6   $��
Войти��6   $��2��6P   $��245,74,194,80q�6d   $��2��6{   
���   ����	#FF5AA8FF���	#FF5AA8FF��6.   �� *SubmitCommand+6�   �� 5"   
   -   5        $��RegBtn��5"   �   $��3��6   $��Регистрация��6   $��245,42,10,38q�6V   
���   ����	#FF455BD8���	#FF455BD8��64   �� *SubmitCommand+6�   �� 5#   
   -   5        $��SkipBtn��5#   �   $��3��6   $�� Пропустить��6   $��10,42,194,39q�6V   $��1��6l   ���	#FFB7B5B5���	#FFB7B5B5��64   �� *SubmitCommand+6�   5$      5%      