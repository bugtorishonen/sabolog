sabolog
=======
https://github.com/bugtorishonen/sabolog

Logs if you are goofing off on the internet.

This program saves log about the active window's title periodically.
Platform: Windows XP/Vista/7/8 (.NET Framework 3.5)
Default output destination is My Documents/sabolog.csv.

Log format:
2014/08/23 16:59:03,"TweetDeck - Google Chrome","C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",6.172
Date of logging, active window's title, process name, idle time (in seconds)

Details are in Japanese.

このプログラムは、自分が仕事中にどれぐらいサボっているかを調ベるためのものです。
機能は、アクティブなウィンドウのタイトルが一定時間ごとに記録されるだけです。
また、ウィンドウを生成したプロセス名とコンピュータのアイドル時間(マウス・キーボード操作がない時間)も同時に記録されるので、解析に使用できます。
解析プログラムは付属しません。記録はcsvファイルに出力されるので、Excel等のアプリケーションで容易に処理できます。
このプログラムはWindows XP/Vista/7/8用です。.NET Framework 3.5が必要です。

設定を特に行わなければ、ログはMy Documentsの"sabolog.csv"に出力されます。
ログの1行は次のような書式です。デフォルトでは15秒ごとに記録されます。
2014/08/23 16:59:03,"TweetDeck - Google Chrome","C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",6.172
ログ取得時刻,アクティブなウィンドウのタイトル,プログラム名,アイドル時間(単位は秒)

ここで、"TweetDeck"が何回ログに出現するかを数えれば、twitterを閲覧してサボっている時間がどれぐらいあったか集計できます。
アイドル時間の記録があるので、これが長時間であれば離席しているという判定が可能です。
YouTubeの閲覧であれば、閲覧中に長時間マウスを動かさないという状況も考えられるので、アイドル時間にかかわらずサボっていると判定することもできるでしょう。

Windowsがロックされているときなどはアクティブウィンドウの取得ができないため、その際はログの該当部分が空欄になります。

ログを有効に活用して労働効率の向上を目指しましょう。
