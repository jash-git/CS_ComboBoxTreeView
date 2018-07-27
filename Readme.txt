C# ComboBoxTreeView元件開發(CS_ComboBoxTreeView)

資料來源:
https://stackoverflow.com/questions/30831485/how-to-add-items-to-combobox-as-tree-list
https://www.brad-smith.info/blog/projects/dropdown-controls
https://www.codeproject.com/Articles/5967/ComboBoxTree
https://www.codeproject.com/Articles/17592/DropDownPanel


我自己根據『https://www.codeproject.com/Articles/5967/ComboBoxTree』範例做了些微調整存成 『self_ComboBoxTree』
	●增加元件初始化屬性預設值設定
	●預設文字方塊是唯讀模式
	●自訂元件『事件轉發』，方便表單抓取選擇值
	●調整TreeView顯示字型和文字方塊一樣
	●修正按下按鈕第一次不會正常顯示下拉式選單
	
有需要請自取