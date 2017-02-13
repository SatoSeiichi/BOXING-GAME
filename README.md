# BOXING-GAME

# プロジェクトについて

ZigSimアプリを使ったボクシングゲームのプロトタイプ　プロジェクト

# 動作環境 

Unity5.5.0

OSX 10.11

# 事前準備

・スマホにZigSimアプリを入れる　　http://zig-project.com/

・PCとスマホを同じWifiにつなげる

・ZigSimアプリのSettingsタブをタップし、

　　[IP ADDRESS]をPCが繋がっているIP ADDRESSと合わせる
 
 [PROTOCOL]をUDPに変更
 
　[DATE DESTINATION　]をOTHER APP　に変更

　[PORT NUMBER]を　50000 に変更(Unity側でも変えれます)

　[MESSAGE FORMAT]を JSON　に変更

・ZigSimアプリのSensorタブをタップし、

　ACCELをタップしチェックをつける

# 動作確認

・mainシーン　を開く

・ZigSimアプリのSettingsタブをタップし[DEVICE UUID]を下記の名前のどれかを割り当てて、Startタブをタップ

　「P1-L」　だと プレイヤー１（青）の右パンチ

　「P1-R」　だと プレイヤー１（青）の左パンチ

　「P2-L」　だと プレイヤー2（赤）の右パンチ

　「P2-R」　だと プレイヤー2（赤）の左パンチ
 
 ・hierarchy上のManagerオブジェクトにアタッチされているZigRecieverのport noでUnity上のPORT NUMBERを変更することが可能です　デフォルト 50000
 
 ・unityをplayしスマホ縦に持って、素早く横に振ってUnity側が反応すれば成功です。
 
 
