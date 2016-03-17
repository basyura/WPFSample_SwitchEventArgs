# WPFSample SwitchEventArgs

## 概要

  - 発生イベントの EventArgs を書き換える
  - UserControl で独自のイベントを定義する

## 構成

```
MainWindow
└── SampleControl
      ├── SampleEventArgs
      └── SampleMouseEventArgs
```

## 内容

```xml
<my:SampleControl 
                  MouseLeftButtonDown="SampleControl_MouseLeftButtonDown"
                  SampleChanged="SampleControl_SampleChanged"
                  />
```

  - SwitchEvent ボタンをクリックすると SampleMouseEventArgs イベントで通知される
  - RaiseSampleEvent ボタンをクリックすると SampleChanged イベントが発生する

## 参考 URL

  - [WPF4.5入門 その46 「WPFのイベントシステム」](http://blog.okazuki.jp/entry/2014/08/22/211021)

