   M S B A M L   `   `   `  ����I  EWpfNotepadMvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfNotepadMvvmWpfNotepadMvvm  5      C&clr-namespace:WpfNotepadMvvm.ConverterWpfNotepadMvvm.Converter  5      E'clr-namespace:WpfNotepadMvvm.ViewModelsWpfNotepadMvvm.ViewModels  5	          WpfNotepadMvvm.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfNotepadMvvm     5      9local1&clr-namespace:WpfNotepadMvvm.Converter     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      >
viewmodels'clr-namespace:WpfNotepadMvvm.ViewModels     5	        � Title$  Notepad��5
      
�������$	��700��5      $	��500��5       � DataContext 5      -   'WpfNotepadMvvm.ViewModels.MainViewModel  5   
    � 	Resources 5      2   ,WpfNotepadMvvm.Converter.BooleanTextWrapping   BooleanTextWrapping��%   &	          5   
   6%   5      .��5      ]� .+�5   
   o� 
�������$	��Top=�5      $��15(�5      $
��Bold"�5      @�5      m� 5"      $
��File��68    6   �� *File+.@�5#      m� $	��New��6>    m� Command 6   �� *
NewCommand+6>   m� 5$      $
��Open��6?    6   �� *OpenCommand+6?   m� 5%      $
��Save��6?    6   �� *SaveCommand+6?   m� 5&      $��Save As��6A    6   �� *SaveAsCommand+6A   5'      m� 5*      $��Format��6:    6   �� *Editor+.@�5+      m� $��Format��6A    6   �� *FormatCommand+6A   m� 5,      $��	Word Wrap��6?    6   �� *WrapCommand+6?   5-      m� 50      $
��Help��52       51      �� *Help+.@�53      m� $��About��6?    6   �� *HelpCommand+6?   54      56      ]� 59   
   .+�5;      �� $��Bottom=�5=       5<      �� *File.Document+��5>      �� *
FilePath+�� 5@      
������� �� AcceptsReturn$
 True��5B       �� 
AcceptsTab$
 True��5C      $	��Top=�5E      " �� VerticalScrollBarVisibility$ Visible=�5L       5D      �� *Editor+��5F      �� *Format.Family+��5G      �� *Format.Size+��5H      �� *Format.Style+��5I      �� *Format.Weight+��5J      �� *Document.Text+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�	 �� TextWrapping	 5K      �� *Format.IsWrapped+
 �� 	Converter#
 [  5L      5M      5O      5P      