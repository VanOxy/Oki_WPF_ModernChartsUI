   M S B A M L   `   `   `  ����e  aDe.TorstenMandelkow.MetroChart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d5b8d1bbc99c4a2awTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChartDe.TorstenMandelkow.MetroChart  5   	    Wpf_ModernCharts!   Wpf_ModernCharts.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   fchartTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChart     5   	     � Title$  
MainWindow��5   	    � DataContext 5   	   ��    Locator �� Source# [   �� Path$
 Main�.��5      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��Center=�6   $��10q�60   $��1��6<   .+�5      �� $��50��6   $	��Add��6    ��6.   �� *ButtonCommand+��5      ��  �� ElementName$ SelectedCountry��$ SelectedItem��� 5      -   5         ��Name$ SelectedCountry��5      ��60   �� *PopulationNames+5      -   'De.TorstenMandelkow.MetroChart.PieChart  5   
   .   (De.TorstenMandelkow.MetroChart.ChartBase   ChartSubTitle$ Population in millions��6      
ChartTitle$ Countries by population��5      $��0��66   	   Series	 5      0   *De.TorstenMandelkow.MetroChart.ChartSeries  
   DisplayMember$

 Name��6$      SeriesTitle$ World largest populations��5         ValueMember$ Count��5      ��5      �� $ Populations�5      5      5      5      