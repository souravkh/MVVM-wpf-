   M S B A M L   `   `   `  ����@  <Mvvm4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Mvvm4.ViewModelMvvm4.ViewModel  5      'clr-namespace:Mvvm4.View
Mvvm4.View  5          Mvvm4.View.MultiView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,vmclr-namespace:Mvvm4.ViewModel     5      *localclr-namespace:Mvvm4.View     5        � 	Resources  5
      $   Mvvm4.ViewModel.MultiViewModel   MultiViewModel��%   &	          5   
   6   5      .��5      �  � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $��90 �6   �� 5      $��90 �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��1��6   $�� Number1��6-   �� 5   
   $��0��6+   $��2��68   ��6   �� *	Number1+68   �� 5   
   $��1��6   $��1��6   $�� Number2��6-   �� 5    
   $��1��6+   $��2��68   ��6   �� *	Number2+68   �� 5"   
   $
��Show��6   $��2��6@   $��2��6P   ��6    �� *ShowCommand+6P   5$      5%      