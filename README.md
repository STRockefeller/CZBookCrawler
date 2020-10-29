# CZBookCrawler

因為目標是中文小說網站所以就以中文作說明

## 聲明

這是網站 [小說狂人](https://czbooks.net/) 的爬蟲軟體

本軟體僅是個人練習程式撰寫所作

本人無法保證該網站上的所有文章都是經由正版途徑取得

非免費文章未經原作者同意請勿任意下載或散佈

## 使用方法

### 爬蟲

![](https://i.imgur.com/yJ3K4rh.png)

在`URL`欄位輸入目標小說**目錄頁面**網址

`Delay(ms)`欄位填入爬蟲每個頁面的延遲時間(毫秒)，建議設定延遲時間避免造成該網站伺服器負擔。

之後按下`Confirm`按鍵

等進度條結束後即成功爬取所有章節內容

此時`Save to DataBase`以及`Export As Text`兩個按鍵會變為有效，分別可以將剛才爬取到的內容存入資料庫或輸出成文字檔，檔案可以在跟目錄的`DataBase` 和`Download`資料夾底下找到。



### 從資料庫讀取

![](https://i.imgur.com/e1n3wMT.png)

曾經存進資料庫的文章，只要在`Novel Name`處輸入小說名稱接著按下`Confirm`就可以直接閱讀了

若欲刪除文章可以只要在`Novel Name`處輸入小說名稱接著按下`Delete`執行刪除動作。



### 閱讀

不論是爬蟲動作結束或者從資料庫讀出文章，在畫面右方都會顯示出第一章的文章內容。

切換章節可以透過:

1. 在下方Page處輸入章節數
2. 透過下方兩個按鍵切換上一頁、下一頁
3. 透過鍵盤左右鍵切換上一頁、下一頁



---

## 心得

時隔近兩個月這是我第二次寫C#爬蟲

上一次是 `小説家になろう` 網站的爬蟲

為了驗證這段時間所學，理所當然這次得作品比起上次要有更多、更完善的功能。

以下回顧這次的新嘗試和成果。

### 爬蟲部分

同樣是小說閱讀網站，這次的難度較前次稍高一點點，`小説家になろう`中文章的路徑相當單純都是`.../目錄/章節數`而`czbook`則是`.../目錄/不規律的字串`所以不能把章節數+1連到下一章節，而是必須在目錄頁面先爬取章節清單。

另外先前寫爬蟲的時候還沒學過`Linq`其實對那些語法都是似懂非懂的，兩個月來平均每天寫一到兩題`CodeWars`現在自忖對`Linq`已經有相當的熟悉度了。今天一寫果然.....並沒有甚麼差別，因為動作太簡單並不需要用到高深的`Linq`技巧。

### 非同步

好吧，這個程式其實用不到非同步，他就只是個爬蟲程式，就算爬蟲過程中可以操作其他控制項也沒有必要。

寫成非同步純粹是自找麻煩，但畢竟是練習作，總要來點挑戰。

加了一堆Task後我的主畫面就可以在爬蟲期間隨便動了

另外一不小心又搞出了好久不見的狀況**跨執行緒作業無效**

查了下之前的筆記用`delegate`和`callback method`搞定了

### 類別圖

這次是真的先規劃好要做哪些功能才動手的。

最後的成果也和規畫得差不多。

### 進度條

其實沒什麼大不了的地方，但之前都沒用過這東西

因為稍長的文章要爬不少時間，讓我實在無法確定我的程式是不是還在動，所以臨時決定製作進度條。

一樣是作成非同步

### 資料庫部分

老樣子使用熟悉的SQLite資料庫，沒什麼大問題

沒有使用`Linq2SQLite`，因為資料表並沒有事先建好，而且可能頻繁寫入，所以必須先建好對應類別的`Linq2SQLite`並不適合。

剛開始在Insert資料時有跳過Exception最初懷疑是SQLite的Text無法存入過多的文字量，Google了一下得知Text可以存約兩百萬字我就知道是其他問題了，最後原因是因為書名有`()`或其他非法字元，然後我拿書名作為table名稱建立表格，所以變成illegal syntax。

### 閱讀部分

就是把文章內容顯示出來，沒啥特別的。

### 鍵盤事件

跟進度條一樣，很簡單的東西，只是之前都沒用過。

