   M S B A M L   `   `   `  ����I  EMsl.HtmlEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Msl.HtmlEditorMsl.HtmlEditor  5      $    Msl.HtmlEditor.HyperlinkDialog   5   	   ^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   8x,http://schemas.microsoft.com/winfx/2006/xaml    5   	   ,localclr-namespace:Msl.HtmlEditor    5        � WindowStartupLocation$  CenterOwner=�5   	    � 
ResizeMode$ NoResize=�6-    � ShowInTaskbar .   � Title$ 插入超链接��5   	   $	��140��6   $	��300��6$    � Icon$@ :/Msl.HtmlEditor;Component/Resources/Image/ke-icon-link.png��5   	    � 	Resources 5       �� 
TargetType �� Property �� Value-  'Msl.HtmlEditor.StringToBooleanConverter   StrBoolConverter��%:  '��       '�� L     '�� �     &	  �     �� 5	   
   " ��6   .�5
      ��  � ��$ Center=�69   5      �� 5   
   " ��6   .�5      ��  � ��$ 4q�6'   �� 5       � ��$ 22��6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 56��6)   5        5   
   6)   5      .��5      � ���	#FFEFEFEF.+�5   
   ]� .+�5      �� $��Bottom=�6   	 �� Padding$	 8q�6-   ._�5      �� 
 �� Orientation$
 
Horizontal=�6   $��Right=�66   .+�5      �� -   5         ��Name$ btnOK��5      $	��8,0q�6,   $��确定��69   {�6F   ��  �� Path$	 URL� �� Mode$ OneWay=� �� 	Converter# [  �� 5      -   5        $ 	btnCancel��5      $��取消��60   5      5      �� 5      $	 8q�6   ._�5      �  � ColumnDefinitions 5      �� 5       $
��Auto �6+   �� 5!       � RowDefinitions 5#      �� 5$      $
��Auto �6(   �� 5%      $
��Auto �6(   .+�5'      �� $��链接地址��6   $��0��6+   �� 5(      $��显示文本��6   $��1��6+   �� 5)      $��1��6]   $��0��6m   ��6   �� $	 URL� �� UpdateSourceTrigger$ PropertyChanged=�6m   �� 5*      $��1��69   $��1��6I   ��6   �� $
 Text�6I   5+      5,      5-      5.      5/      