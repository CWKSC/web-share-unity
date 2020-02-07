# UI

[Back To Index 返回目錄](../README.md)

___

## Text tutorial

[User Interface (UI) - Unity](https://unity3d.com/cn/learn/tutorials/s/user-interface-ui)

[UI RectTransform - Unity](https://unity3d.com/learn/tutorials/modules/beginner/ui/rect-transform?playlist=17111)

[UI Events and Event Triggers - Unity](https://unity3d.com/learn/tutorials/topics/user-interface-ui/ui-events-and-event-triggers?playlist=17111)

[Unity3D 教學．CG數位學習網](http://www.cg.com.tw/Unity/Content/Unity_23.php)

[Unity - Manual: Canvas](https://docs.unity3d.com/Manual/UICanvas.html)

[UI Canvas - Unity](https://unity3d.com/cn/learn/tutorials/topics/user-interface-ui/ui-canvas?playlist=17111)

### Video tutorial

[How to make UI in UNITY - EASY TUTORIAL - YouTube](https://www.youtube.com/watch?v=_RIsfVOqTaE)

[START MENU in Unity - YouTube](https://www.youtube.com/watch?v=zc8ac_qUXQY)

### Github Collection

[mob-sakai/UIEffect: UIEffect is an effect component for uGUI element in Unity. Let's decorate your UI with effects!](https://github.com/mob-sakai/UIEffect)

___

- Canvas
- Rect Transform
- Text
- Button
- ScrolBar
- Image

___

## Canvas

- [Unity - Manual: Canvas](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/Manual/UICanvas.html)

- [UI Canvas - Unity](https://link.zhihu.com/?target=https%3A//unity3d.com/cn/learn/tutorials/topics/user-interface-ui/ui-canvas%3Fplaylist%3D17111)

- [UGUI的深度 - 简书](https://link.zhihu.com/?target=https%3A//www.jianshu.com/p/712da6cb6852)

- [Unity3D学习笔记uGUI（9）：Canvas详述-腾讯游戏学院](https://link.zhihu.com/?target=https%3A//gameinstitute.qq.com/community/detail/112504)

- ### Draw order of elements 绘制元件的次序

  - [Unity - Scripting API: Transform.GetSiblingIndex](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Transform.GetSiblingIndex.html)
  - [Unity - Scripting API: Transform.SetAsFirstSibling](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Transform.SetAsFirstSibling.html)
  - [Unity - Scripting API: Transform.SetAsLastSibling](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Transform.SetAsLastSibling.html)
  - [Unity - Scripting API: Transform.SetSiblingIndex](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Transform.SetSiblingIndex.html)

- ### Canvas 組件

  - #### Render Modes 渲染模式

    - [Unity学习笔记——UGUI Canvas - 掘金](https://link.zhihu.com/?target=https%3A//juejin.im/post/5b29bb886fb9a00e315c1f03)

    - [unity 搞懂Canvas的Render Mode的三种模式 - fdyshlk的博客 - CSDN博客](https://link.zhihu.com/?target=https%3A//blog.csdn.net/fdyshlk/article/details/78509909)

    - ##### Render Mode 公有属性

      - ###### Additional Shader Channels

        - [Unity - Scripting API: Canvas.additionalShaderChannels](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-additionalShaderChannels.html)
        - [Unity - Scripting API: AdditionalCanvasShaderChannels](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/AdditionalCanvasShaderChannels.html)
        - [None](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/AdditionalCanvasShaderChannels.None.html)
        - [TexCoord1](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/AdditionalCanvasShaderChannels.TexCoord1.html)
        - [TexCoord2](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/AdditionalCanvasShaderChannels.TexCoord2.html)
        - [TexCoord3](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/AdditionalCanvasShaderChannels.TexCoord3.html)
        - [Normal](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/AdditionalCanvasShaderChannels.Normal.html)
        - [Tangent](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/AdditionalCanvasShaderChannels.Tangent.html)

    - ##### Render Mode - Screen Space - Overlay 属性

      - ###### Pixel Perfect

        - [What does 'pixel perfect' mean? - Quora](https://link.zhihu.com/?target=https%3A//www.quora.com/What-does-pixel-perfect-mean)
        - [Unity - Scripting API: Canvas.pixelPerfect](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-pixelPerfect.html)

      - ###### Sort Order

        - [Unity - Scripting API: Canvas.sortingOrder](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-sortingOrder.html)

      - ###### Target Display

        - [Unity - Scripting API: Canvas.targetDisplay](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-targetDisplay.html)

    - ##### Render Mode - Screen Space - Camera 属性

      - ###### Pixel Perfect

        - [What does 'pixel perfect' mean? - Quora](https://link.zhihu.com/?target=https%3A//www.quora.com/What-does-pixel-perfect-mean)
        - [Unity - Scripting API: Canvas.pixelPerfect](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-pixelPerfect.html)

      - ###### Render Camera

        - [Unity - Scripting API: Canvas.worldCamera](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-worldCamera.html)
        - [unity3d - How to change the Canvas Render Camera via C# - Stack Overflow](https://link.zhihu.com/?target=https%3A//stackoverflow.com/questions/41172136/how-to-change-the-canvas-render-camera-via-c-sharp)

      - ###### Plane Distance

        - [Unity - Scripting API: Canvas.planeDistance](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-planeDistance.html)

      - ###### Sorting Layer

        - [Unity - Scripting API: Canvas.sortingLayerID](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-sortingLayerID.html)
        - [Unity - Scripting API: Canvas.sortingLayerName](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-sortingLayerName.html)
        - [不再混淆Layer,sorting layer,order in layer (unity5.3.6版本) - yq398934906的博客 - CSDN博客](https://link.zhihu.com/?target=https%3A//blog.csdn.net/yq398934906/article/details/68484665)

      - ###### Order in Layer

        - （空的，暂时没有参考网站。）

    - ##### Render Mode - World Space 属性

      - ###### Event Camera

        - [Unity - Scripting API: Canvas.worldCamera](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-worldCamera.html)
        - [How to set world space canvas event camera at runtime? - Unity Forum](https://link.zhihu.com/?target=https%3A//forum.unity.com/threads/how-to-set-world-space-canvas-event-camera-at-runtime.268044/)

      - ###### Sorting Layer

        - [Unity - Scripting API: Canvas.sortingLayerID](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-sortingLayerID.html) 
        - [Unity - Scripting API: Canvas.sortingLayerName](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/ScriptReference/Canvas-sortingLayerName.html) 
        - [不再混淆Layer,sorting layer,order in layer (unity5.3.6版本) - yq398934906的博客 - CSDN博客](https://link.zhihu.com/?target=https%3A//blog.csdn.net/yq398934906/article/details/68484665)

      - ###### Order in Layer

        - （空的，暂时没有参考网站。）

  - #### Render Modes 下的渲染优先级

    - [UGUI渲染优先级 - zhangzhen551的专栏 - CSDN博客](https://link.zhihu.com/?target=https%3A//blog.csdn.net/zhangzhen551/article/details/43938587)
    - [UGUI学习（二）渲染模式和层级顺序 - nanzhengluo的博客 - CSDN博客](https://link.zhihu.com/?target=https%3A//blog.csdn.net/nanzhengluo/article/details/72864599)

- ### Canvas Scaler 組件

  - [Unity - Manual: Canvas Scaler](https://link.zhihu.com/?target=https%3A//docs.unity3d.com/Manual/script-CanvasScaler.html)
  - [Unity UGUI 原理篇(二)：Canvas Scaler 縮放核心 | ARKAI Studio]( [http://www.arkaistudio.com/blog/2016/03/28/unity-ugui-%E5%8E%9F%E7%90%86%E7%AF%87%E4%BA%8C%EF%BC%9Acanvas-scaler-%E7%B8%AE%E6%94%BE%E6%A0%B8%E5%BF%83/](http://www.arkaistudio.com/blog/2016/03/28/unity-ugui-原理篇二：canvas-scaler-縮放核心/) )
  - [[UGUI\]深入理解Canvas Scaler - 安宁技术博客 - CSDN博客](https://link.zhihu.com/?target=https%3A//blog.csdn.net/inlet511/article/details/46822383)

- [UGUI之CanvasScaler的正确用法 - u012842807的专栏 - CSDN博客]( https://blog.csdn.net/u012842807/article/details/47019457 )

  - [Unity Canvas Scaler详解 - CheerseUp的博客 - CSDN博客](https://link.zhihu.com/?target=https%3A//blog.csdn.net/a1459078670/article/details/78384129)

- [关于Canvas Scaler的作用 - Tempest_BLOG - CSDN博客]( https://blog.csdn.net/qq_28824335/article/details/48250819 )

- ### Graphic Raycaster 組件

  - （空的，暂时没有参考网站。）

## Rect Transform

* [Unity - Manual: Rect Transform](https://docs.unity3d.com/Manual/class-RectTransform.html)
* [Unity - Manual: Basic Layout](https://docs.unity3d.com/Manual/UIBasicLayout.html)
* [成為 UGUI 的排版大師 - 一次精通 RectTransform | Fourdesire Blog](http://blog.fourdesire.com/2018/07/03/成為-ugui-的排版大師-一次精通-recttransform/)
* [Unity进阶技巧 - RectTransform详解 - 简书](https://www.jianshu.com/p/dbefa746e50d)
* [UGUI——RectTransform详解 - SerenaHaven的博客 - CSDN博客](https://blog.csdn.net/serenahaven/article/details/78826851)
* [Unity UGUI 的RectTransform参数的设置 - YaoLifeng的博客 - CSDN博客](https://blog.csdn.net/qq_30454411/article/details/79640951)
* [Unity - Scripting API: RectTransform](https://docs.unity3d.com/ScriptReference/RectTransform.html)
* [修改RectTransform的值 - 糯米粥 - 博客园](https://www.cnblogs.com/nsky/p/5045201.html)
* [动态修改RectTransform的值 - ⎝⏠⏝⏠⎠ - CSDN博客](https://blog.csdn.net/qq_17758883/article/details/78568460)



## Text

- [Unity TextMeshPro 中文字體 @ 迷途 :: 痞客邦 ::](http://cindyalex.pixnet.net/blog/post/238930883-unity-textmeshpro-中文字體)
- [Game view appears extremely pixelated but scene view is fine - Unity Answers](https://answers.unity.com/questions/1252741/game-view-appears-extremely-pixelated-but-scene-vi.html)
- [UI Text - Unity](https://unity3d.com/learn/tutorials/topics/user-interface-ui/ui-text?playlist=17111)



## Button

- [UI Button - Unity](https://unity3d.com/learn/tutorials/topics/user-interface-ui/ui-button?playlist=17111)
- [Unity UGUI 按钮绑定事件的 4 种方式 - Hu&Fei - 博客园](https://www.cnblogs.com/isayes/p/6370168.html)
- [Unity - Scripting API: UI.Button.onClick](https://docs.unity3d.com/ScriptReference/UI.Button-onClick.html)



## ScrolBar

- [【Unity】捲動選單 scroll list - 【Unity遊戲製作】勇者拉德小酒館](https://jerrard-liu.blogspot.com/2015/06/ScrollList.html)
- [【Unity】UI Scrollbar & Scroll Rect - 【Unity遊戲製作】勇者拉德小酒館](https://jerrard-liu.blogspot.com/2015/09/Scrollbar-Rect.html)
- [Unity - Manual: Scrollbar](https://docs.unity3d.com/Manual/script-Scrollbar.html)
- [UI ScrollRect - Unity](https://unity3d.com/learn/tutorials/modules/beginner/ui/ui-scroll-rect)
- [Unity 捲動效果 Scroll Rect / Scrollbar @ 迷途 :: 痞客邦 ::](http://cindyalex.pixnet.net/blog/post/238874307-unity-c%23-捲動效果-scroll-rect---scroll-bar)



## Image

- [Unity UGUI Image 九宮格使用 血條設計 @ Weight遊戲作家 :: 痞客邦 ::](http://a032332852.pixnet.net/blog/post/280769818-unity-ugui-image-九宮格使用-血條設計)
- [Unity UGUI基础之Image - 神码编程 - CSDN博客](https://blog.csdn.net/qq992817263/article/details/51754189)
- [Unity3D UGUI 源码学习 Image | Aillieo Collection](https://aillieo.cn/post/2018-07-20-unity-3d-ugui-source-code-10/)

