   M S B A M L   `   `   `  ����  
NTFSStruct     NTFSStruct.fmStructCatalog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$   ��5   	   $	��700��6   $��956.5��6    � 
ResizeMode$ NoResize=�6-    � WindowStartupLocation$ CenterScreen=�6Z   .��5      � $��0,0,-6,0q�6   .+�5   
   �� $W��QСтрукутура на диске(большие файлы, катологи)��6   $
��Left=�6G   $��	25,25,0,0q�6b   $	��Top=�6u   $��16(�6�   $
��Bold"�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5	         
BlurRadius$ 14Q�6#   5      �� 5   
   -   5         ��Name$ imSmallCatalog��5      $
��Left=�6(   $	��181��6C   $��	25,71,0,0q�6P   $	��Top=�6c   $	��659��6{    � ToolTip$T NФайловая запись MFT для небольшего каталога��6�   6  �� 5   
   -   5        $ imBigCatalog��5      $
��Left=�6&   $	��196��6A   $��
25,235,0,0q�6N   $	��Top=�6b   $	��659��6z   $� �Файловая запись для большего католога с нерезидентным индексом имен файлов��6�   6%  �� 5   
   -   5        $ 
imIndexBuf��5      $��65��6$   $��201,366,272,0q�60   $	��Top=�6G   $
��Fill=�6�   $3 -Индексные буферы(index bufers)��6�   6�   �� 5   
   -   5        $ imVirt��5      $
��Left=�6    $	��215��6;   $��
25,446,0,0q�6H   $	��Top=�6\   $	��659��6t   $f `Отображение VCN-LCN для нерезидентного атрибута данных��6�   6�   �� 5   
   -   5         ��Name$ lbBack��5      $��
Назад��6    $
��Left=�60   $��
887,30,0,0q�6K   $	��Top=�6_   $
��Bold"�6w   6�   �� 5   
   -   5         ��Name$ txtExplanation��5      	 �� 
IsReadOnly	 . $
��Left=�6<   $	��572��6W   $��
702,71,0,0q�6d   
 �� TextWrapping$

 Wrap=�6x   $	��Top=�6�   $	��230��6�   5      5      