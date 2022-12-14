Imports System.IO
Imports System.Runtime.InteropServices
Imports Mirage.Basic.Engine.Enumerations
Imports SFML.Graphics
Imports SFML.System
Imports Mirage.Basic.Engine
Imports Time = Mirage.Basic.Engine.Time
Imports SFML.Window

Module C_Graphics

#Region "Declarations"

    Friend GameWindow As RenderWindow
    Friend TilesetWindow As RenderWindow

    Friend EditorSkill_Icon As RenderWindow
    Friend EditorAnimation_Anim1 As RenderWindow
    Friend EditorAnimation_Anim2 As RenderWindow

    Friend SfmlGameFont As Font

    Friend CursorGfx As Texture
    Friend CursorSprite As Sprite
    Friend CursorInfo As GraphicInfo

    'TileSets
    Friend TileSetTexture() As Texture
    Friend TileSetImgsGFX() As Bitmap

    Friend TileSetSprite() As Sprite
    Friend TileSetTextureInfo() As GraphicInfo

    'Characters
    Friend CharacterGfx() As Texture

    Friend CharacterSprite() As Sprite
    Friend CharacterGfxInfo() As GraphicInfo

    'Paperdolls
    Friend PaperDollGfx() As Texture

    Friend PaperDollSprite() As Sprite
    Friend PaperDollGfxInfo() As GraphicInfo

    'Items
    Friend ItemsGfx() As Texture

    Friend ItemsSprite() As Sprite
    Friend ItemsGfxInfo() As GraphicInfo

    'Resources
    Friend ResourcesGfx() As Texture

    Friend ResourcesSprite() As Sprite
    Friend ResourcesGfxInfo() As GraphicInfo

    'Animations
    Friend AnimationsGfx() As Texture

    Friend AnimationsSprite() As Sprite
    Friend AnimationsGfxInfo() As GraphicInfo

    'Skills
    Friend SkillIconsGfx() As Texture

    Friend SkillIconsSprite() As Sprite
    Friend SkillIconsGfxInfo() As GraphicInfo

    'Housing
    Friend FurnitureGfx() As Texture

    Friend FurnitureSprite() As Sprite
    Friend FurnitureGfxInfo() As GraphicInfo

    'Faces
    Friend FacesGfx() As Texture

    Friend FacesSprite() As Sprite
    Friend FacesGfxInfo() As GraphicInfo

    'Projectiles
    Friend ProjectileGfx() As Texture

    Friend ProjectileSprite() As Sprite
    Friend ProjectileGfxInfo() As GraphicInfo

    'Fogs
    Friend FogGfx() As Texture

    Friend FogSprite() As Sprite
    Friend FogGfxInfo() As GraphicInfo

    'Emotes
    Friend EmotesGfx() As Texture

    Friend EmotesSprite() As Sprite
    Friend EmotesGfxInfo() As GraphicInfo

    'Panoramas
    Friend PanoramasGfx() As Texture

    Friend PanoramasSprite() As Sprite
    Friend PanoramasGfxInfo() As GraphicInfo

    'Parallax
    Friend ParallaxGfx() As Texture

    Friend ParallaxSprite() As Sprite
    Friend ParallaxGfxInfo() As GraphicInfo

    'Pictures
    Friend PictureGfx() As Texture

    Friend PictureSprite() As Sprite
    Friend PictureGfxInfo() As GraphicInfo

    'Blood
    Friend BloodGfx As Texture

    Friend BloodSprite As Sprite
    Friend BloodGfxInfo As GraphicInfo

    'Directions
    Friend DirectionsGfx As Texture

    Friend DirectionsSprite As Sprite
    Friend DirectionsGfxInfo As GraphicInfo

    'Weather
    Friend WeatherGfx As Texture

    Friend WeatherSprite As Sprite
    Friend WeatherGfxInfo As GraphicInfo

    'Hotbar
    Friend HotBarGfx As Texture

    Friend HotBarSprite As Sprite
    Friend HotBarGfxInfo As GraphicInfo

    'Chat
    Friend ChatWindowGfx As Texture

    Friend ChatWindowSprite As Sprite
    Friend ChatWindowGfxInfo As GraphicInfo

    'MyChat
    Friend MyChatWindowGfx As Texture

    Friend MyChatWindowSprite As Sprite
    Friend MyChatWindowGfxInfo As GraphicInfo

    'Buttons
    Friend ButtonGfx As Texture

    Friend ButtonSprite As Sprite
    Friend ButtonGfxInfo As GraphicInfo
    Friend ButtonHoverGfx As Texture
    Friend ButtonHoverSprite As Sprite
    Friend ButtonHoverGfxInfo As GraphicInfo

    'Hud
    Friend HudPanelGfx As Texture

    Friend HudPanelSprite As Sprite
    Friend HudPanelGfxInfo As GraphicInfo

    'Bars
    Friend HpBarGfx As Texture

    Friend HpBarSprite As Sprite
    Friend HpBarGfxInfo As GraphicInfo
    Friend MpBarGfx As Texture
    Friend MpBarSprite As Sprite
    Friend MpBarGfxInfo As GraphicInfo
    Friend ExpBarGfx As Texture
    Friend ExpBarSprite As Sprite
    Friend ExpBarGfxInfo As GraphicInfo

    Friend XpBarPanelGfx As Texture
    Friend XpBarPanelSprite As Sprite
    Friend XpBarPanelGfxInfo As GraphicInfo

    Friend ActionPanelGfx As Texture
    Friend ActionPanelSprite As Sprite
    Friend ActionPanelGfxInfo As GraphicInfo
    Friend ActionPanelButtonsGfx(8) As Texture
    Friend ActionPanelButtonsSprite(8) As Sprite
    Friend ActionPanelButtonGfxInfo(8) As GraphicInfo

    Friend InvPanelGfx As Texture
    Friend InvPanelSprite As Sprite
    Friend InvPanelGfxInfo As GraphicInfo

    Friend SkillPanelGfx As Texture
    Friend SkillPanelSprite As Sprite
    Friend SkillPanelGfxInfo As GraphicInfo

    Friend CharPanelGfx As Texture
    Friend CharPanelSprite As Sprite
    Friend CharPanelGfxInfo As GraphicInfo
    Friend CharPanelPlusGfx As Texture
    Friend CharPanelPlusSprite As Sprite
    Friend CharPanelPlusGfxInfo As GraphicInfo
    Friend CharPanelMinGfx As Texture
    Friend CharPanelMinSprite As Sprite
    Friend CharPanelMinGfxInfo As GraphicInfo

    Friend BankPanelGfx As Texture
    Friend BankPanelSprite As Sprite
    Friend BankPanelGfxInfo As GraphicInfo

    Friend TradePanelGfx As Texture
    Friend TradePanelSprite As Sprite
    Friend TradePanelGfxInfo As GraphicInfo

    Friend ShopPanelGfx As Texture
    Friend ShopPanelSprite As Sprite
    Friend ShopPanelGfxInfo As GraphicInfo

    Friend EventChatGfx As Texture
    Friend EventChatSprite As Sprite
    Friend EventChatGfxInfo As GraphicInfo

    Friend TargetGfx As Texture
    Friend TargetSprite As Sprite
    Friend TargetGfxInfo As GraphicInfo

    Friend DescriptionGfx As Texture
    Friend DescriptionSprite As Sprite
    Friend DescriptionGfxInfo As GraphicInfo

    Friend QuestGfx As Texture
    Friend QuestSprite As Sprite
    Friend QuestGfxInfo As GraphicInfo

    Friend CraftGfx As Texture
    Friend CraftSprite As Sprite
    Friend CraftGfxInfo As GraphicInfo

    Friend ProgBarGfx As Texture
    Friend ProgBarSprite As Sprite
    Friend ProgBarGfxInfo As GraphicInfo

    Friend RClickGfx As Texture
    Friend RClickSprite As Sprite
    Friend RClickGfxInfo As GraphicInfo

    Friend ChatBubbleGfx As Texture
    Friend ChatBubbleSprite As Sprite
    Friend ChatBubbleGfxInfo As GraphicInfo

    Friend PetStatsGfx As Texture
    Friend PetStatsSprite As Sprite
    Friend PetStatsGfxInfo As GraphicInfo

    Friend PetBarGfx As Texture
    Friend PetBarSprite As Sprite
    Friend PetbarGfxInfo As GraphicInfo

    Friend MapTintGfx As New RenderTexture(3860, 2160)
    Friend MapTintSprite As Sprite

    Friend MapFadeSprite As Sprite

    ' Number of graphic files
    Friend NumTileSets As Integer
    Friend NumCharacters As Integer
    Friend NumPaperdolls As Integer
    Friend NumItems As Integer
    Friend NumResources As Integer
    Friend NumAnimations As Integer
    Friend NumSkillIcons As Integer
    Friend NumFaces As Integer
    Friend NumFogs As Integer
    Friend NumEmotes As Integer
    Friend NumPanorama As Integer
    Friend NumParallax As Integer
    Friend NumPictures As Integer

    ' Day/Night
    Friend NightGfx As New RenderTexture(3860, 2160)
    Friend NightSprite As Sprite
    Friend LightGfx As Texture
    Friend LightDynamicGfx As Texture
    Friend LightSprite As Sprite
    Friend LightDynamicSprite As Sprite
    Friend LightGfxInfo As GraphicInfo

#End Region

#Region "Types"

    Public Structure GraphicInfo
        Dim Width As Integer
        Dim Height As Integer
        Dim IsLoaded As Boolean
        Dim TextureTimer As Integer
    End Structure

    Public Structure GraphicsTiles
        Dim Tile(,) As Texture
    End Structure


#End Region

#Region "initialisation"

    Sub InitGraphics()

        GameWindow = New RenderWindow(FrmGame.picscreen.Handle)
        SfmlGameFont = New Font(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\" + FontName)

        'this stuff only loads when needed :)
        ReDim TileSetImgsGFX(0 To NumTileSets)
        ReDim TileSetTexture(NumTileSets)
        ReDim TileSetSprite(NumTileSets)
        ReDim TileSetTextureInfo(NumTileSets)

        ReDim CharacterGfx(NumCharacters)
        ReDim CharacterSprite(NumCharacters)
        ReDim CharacterGfxInfo(NumCharacters)

        ReDim PaperDollGfx(NumPaperdolls)
        ReDim PaperDollSprite(NumPaperdolls)
        ReDim PaperDollGfxInfo(NumPaperdolls)

        ReDim ItemsGfx(NumItems)
        ReDim ItemsSprite(NumItems)
        ReDim ItemsGfxInfo(NumItems)

        ReDim ResourcesGfx(NumResources)
        ReDim ResourcesSprite(NumResources)
        ReDim ResourcesGfxInfo(NumResources)

        ReDim AnimationsGfx(NumAnimations)
        ReDim AnimationsSprite(NumAnimations)
        ReDim AnimationsGfxInfo(NumAnimations)

        ReDim SkillIconsGfx(NumSkillIcons)
        ReDim SkillIconsSprite(NumSkillIcons)
        ReDim SkillIconsGfxInfo(NumSkillIcons)

        ReDim FacesGfx(NumFaces)
        ReDim FacesSprite(NumFaces)
        ReDim FacesGfxInfo(NumFaces)

        ReDim ProjectileGfx(NumProjectiles)
        ReDim ProjectileSprite(NumProjectiles)
        ReDim ProjectileGfxInfo(NumProjectiles)

        ReDim FogGfx(NumFogs)
        ReDim FogSprite(NumFogs)
        ReDim FogGfxInfo(NumFogs)

        ReDim EmotesGfx(NumEmotes)
        ReDim EmotesSprite(NumEmotes)
        ReDim EmotesGfxInfo(NumEmotes)

        ReDim PanoramasGfx(NumPanorama)
        ReDim PanoramasSprite(NumPanorama)
        ReDim PanoramasGfxInfo(NumPanorama)

        ReDim ParallaxGfx(NumParallax)
        ReDim ParallaxSprite(NumParallax)
        ReDim ParallaxGfxInfo(NumParallax)

        ReDim PictureGfx(NumPictures)
        ReDim PictureSprite(NumPictures)
        ReDim PictureGfxInfo(NumPictures)

        'sadly, gui shit is always needed, so we preload it :/
        CursorInfo = New GraphicInfo
        If File.Exists(Paths.Graphics & "Misc\Cursor" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            CursorGfx = New Texture(Paths.Graphics & "Misc\Cursor" & GfxExt)
            CursorSprite = New Sprite(CursorGfx)

            'Cache the width and height
            CursorInfo.Width = CursorGfx.Size.X
            CursorInfo.Height = CursorGfx.Size.Y
        End If

        BloodGfxInfo = New GraphicInfo
        If File.Exists(Paths.Graphics & "Misc\Blood" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            BloodGfx = New Texture(Paths.Graphics & "Misc\Blood" & GfxExt)
            BloodSprite = New Sprite(BloodGfx)

            'Cache the width and height
            BloodGfxInfo.Width = BloodGfx.Size.X
            BloodGfxInfo.Height = BloodGfx.Size.Y
        End If

        DirectionsGfxInfo = New GraphicInfo
        If File.Exists(Paths.Graphics & "Misc\Direction" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            DirectionsGfx = New Texture(Paths.Graphics & "Misc\Direction" & GfxExt)
            DirectionsSprite = New Sprite(DirectionsGfx)

            'Cache the width and height
            DirectionsGfxInfo.Width = DirectionsGfx.Size.X
            DirectionsGfxInfo.Height = DirectionsGfx.Size.Y
        End If

        WeatherGfxInfo = New GraphicInfo
        If File.Exists(Paths.Graphics & "Misc\Weather" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            WeatherGfx = New Texture(Paths.Graphics & "Misc\Weather" & GfxExt)
            WeatherSprite = New Sprite(WeatherGfx)

            'Cache the width and height
            WeatherGfxInfo.Width = WeatherGfx.Size.X
            WeatherGfxInfo.Height = WeatherGfx.Size.Y
        End If

        HotBarGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\HotBar" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            HotBarGfx = New Texture(Paths.Gui & "Main\HotBar" & GfxExt)
            HotBarSprite = New Sprite(HotBarGfx)

            'Cache the width and height
            HotBarGfxInfo.Width = HotBarGfx.Size.X
            HotBarGfxInfo.Height = HotBarGfx.Size.Y
        End If

        ChatWindowGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\" & "Chat" & GfxExt) Then
            ChatWindowGfx = New Texture(Paths.Gui & "Main\" & "Chat" & GfxExt)
            ChatWindowSprite = New Sprite(ChatWindowGfx)

            'Cache the width and height
            ChatWindowGfxInfo.Width = ChatWindowGfx.Size.X
            ChatWindowGfxInfo.Height = ChatWindowGfx.Size.Y
        End If

        MyChatWindowGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\" & "MyChat" & GfxExt) Then
            MyChatWindowGfx = New Texture(Paths.Gui & "Main\" & "MyChat" & GfxExt)
            MyChatWindowSprite = New Sprite(MyChatWindowGfx)

            'Cache the width and height
            MyChatWindowGfxInfo.Width = MyChatWindowGfx.Size.X
            MyChatWindowGfxInfo.Height = MyChatWindowGfx.Size.Y
        End If

        ButtonGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Button" & GfxExt) Then
            ButtonGfx = New Texture(Paths.Gui & "Button" & GfxExt)
            ButtonSprite = New Sprite(ButtonGfx)

            'Cache the width and height
            ButtonGfxInfo.Width = ButtonGfx.Size.X
            ButtonGfxInfo.Height = ButtonGfx.Size.Y
        End If

        ButtonHoverGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Button_Hover" & GfxExt) Then
            ButtonHoverGfx = New Texture(Paths.Gui & "Button_Hover" & GfxExt)
            ButtonHoverSprite = New Sprite(ButtonHoverGfx)

            'Cache the width and height
            ButtonHoverGfxInfo.Width = ButtonHoverGfx.Size.X
            ButtonHoverGfxInfo.Height = ButtonHoverGfx.Size.Y
        End If

        HudPanelGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\HUD" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            HudPanelGfx = New Texture(Paths.Gui & "Main\HUD" & GfxExt)
            HudPanelSprite = New Sprite(HudPanelGfx)

            'Cache the width and height
            HudPanelGfxInfo.Width = HudPanelGfx.Size.X
            HudPanelGfxInfo.Height = HudPanelGfx.Size.Y
        End If

        HpBarGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "HPBar" & GfxExt) Then
            HpBarGfx = New Texture(Paths.Gui & "HPBar" & GfxExt)
            HpBarSprite = New Sprite(HpBarGfx)

            'Cache the width and height
            HpBarGfxInfo.Width = HpBarGfx.Size.X
            HpBarGfxInfo.Height = HpBarGfx.Size.Y
        End If

        MpBarGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "MPBar" & GfxExt) Then
            MpBarGfx = New Texture(Paths.Gui & "MPBar" & GfxExt)
            MpBarSprite = New Sprite(MpBarGfx)

            'Cache the width and height
            MpBarGfxInfo.Width = MpBarGfx.Size.X
            MpBarGfxInfo.Height = MpBarGfx.Size.Y
        End If

        ExpBarGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "EXPBar" & GfxExt) Then
            ExpBarGfx = New Texture(Paths.Gui & "EXPBar" & GfxExt)
            ExpBarSprite = New Sprite(ExpBarGfx)

            'Cache the width and height
            ExpBarGfxInfo.Width = ExpBarGfx.Size.X
            ExpBarGfxInfo.Height = ExpBarGfx.Size.Y
        End If

        XpBarPanelGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\xpbar" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            XpBarPanelGfx = New Texture(Paths.Gui & "Main\xpbar" & GfxExt)
            XpBarPanelSprite = New Sprite(XpBarPanelGfx)

            'Cache the width and height
            XpBarPanelGfxInfo.Width = XpBarPanelGfx.Size.X
            XpBarPanelGfxInfo.Height = XpBarPanelGfx.Size.Y
        End If

        ActionPanelGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "ActionBar\ActionBar" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            ActionPanelGfx = New Texture(Paths.Gui & "ActionBar\ActionBar" & GfxExt)
            ActionPanelSprite = New Sprite(ActionPanelGfx)

            'Cache the width and height
            ActionPanelGfxInfo.Width = ActionPanelGfx.Size.X
            ActionPanelGfxInfo.Height = ActionPanelGfx.Size.Y
        End If

        InvPanelGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\inventory" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            InvPanelGfx = New Texture(Paths.Gui & "Main\inventory" & GfxExt)
            InvPanelSprite = New Sprite(InvPanelGfx)

            'Cache the width and height
            InvPanelGfxInfo.Width = InvPanelGfx.Size.X
            InvPanelGfxInfo.Height = InvPanelGfx.Size.Y
        End If

        SkillPanelGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\skills" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            SkillPanelGfx = New Texture(Paths.Gui & "Main\skills" & GfxExt)
            SkillPanelSprite = New Sprite(SkillPanelGfx)

            'Cache the width and height
            SkillPanelGfxInfo.Width = SkillPanelGfx.Size.X
            SkillPanelGfxInfo.Height = SkillPanelGfx.Size.Y
        End If

        CharPanelGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\char" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            CharPanelGfx = New Texture(Paths.Gui & "Main\char" & GfxExt)
            CharPanelSprite = New Sprite(CharPanelGfx)

            'Cache the width and height
            CharPanelGfxInfo.Width = CharPanelGfx.Size.X
            CharPanelGfxInfo.Height = CharPanelGfx.Size.Y
        End If

        CharPanelPlusGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\plus" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            CharPanelPlusGfx = New Texture(Paths.Gui & "Main\plus" & GfxExt)
            CharPanelPlusSprite = New Sprite(CharPanelPlusGfx)

            'Cache the width and height
            CharPanelPlusGfxInfo.Width = CharPanelPlusGfx.Size.X
            CharPanelPlusGfxInfo.Height = CharPanelPlusGfx.Size.Y
        End If

        CharPanelMinGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\min" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            CharPanelMinGfx = New Texture(Paths.Gui & "Main\min" & GfxExt)
            CharPanelMinSprite = New Sprite(CharPanelMinGfx)

            'Cache the width and height
            CharPanelMinGfxInfo.Width = CharPanelMinGfx.Size.X
            CharPanelMinGfxInfo.Height = CharPanelMinGfx.Size.Y
        End If

        BankPanelGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\Bank" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            BankPanelGfx = New Texture(Paths.Gui & "Main\Bank" & GfxExt)
            BankPanelSprite = New Sprite(BankPanelGfx)

            'Cache the width and height
            BankPanelGfxInfo.Width = BankPanelGfx.Size.X
            BankPanelGfxInfo.Height = BankPanelGfx.Size.Y
        End If

        ShopPanelGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\Shop" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            ShopPanelGfx = New Texture(Paths.Gui & "Main\Shop" & GfxExt)
            ShopPanelSprite = New Sprite(ShopPanelGfx)

            'Cache the width and height
            ShopPanelGfxInfo.Width = ShopPanelGfx.Size.X
            ShopPanelGfxInfo.Height = ShopPanelGfx.Size.Y
        End If

        TradePanelGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\Trade" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            TradePanelGfx = New Texture(Paths.Gui & "Main\Trade" & GfxExt)
            TradePanelSprite = New Sprite(TradePanelGfx)

            'Cache the width and height
            TradePanelGfxInfo.Width = TradePanelGfx.Size.X
            TradePanelGfxInfo.Height = TradePanelGfx.Size.Y
        End If

        EventChatGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\EventChat" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            EventChatGfx = New Texture(Paths.Gui & "Main\EventChat" & GfxExt)
            EventChatSprite = New Sprite(EventChatGfx)

            'Cache the width and height
            EventChatGfxInfo.Width = EventChatGfx.Size.X
            EventChatGfxInfo.Height = EventChatGfx.Size.Y
        End If

        TargetGfxInfo = New GraphicInfo
        If File.Exists(Paths.Graphics & "Misc\Target" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            TargetGfx = New Texture(Paths.Graphics & "Misc\Target" & GfxExt)
            TargetSprite = New Sprite(TargetGfx)

            'Cache the width and height
            TargetGfxInfo.Width = TargetGfx.Size.X
            TargetGfxInfo.Height = TargetGfx.Size.Y
        End If

        DescriptionGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\" & "Description" & GfxExt) Then
            DescriptionGfx = New Texture(Paths.Gui & "Main\" & "Description" & GfxExt)
            DescriptionSprite = New Sprite(DescriptionGfx)

            'Cache the width and height
            DescriptionGfxInfo.Width = DescriptionGfx.Size.X
            DescriptionGfxInfo.Height = DescriptionGfx.Size.Y
        End If

        RClickGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\" & "RightClick" & GfxExt) Then
            RClickGfx = New Texture(Paths.Gui & "Main\" & "RightClick" & GfxExt)
            RClickSprite = New Sprite(RClickGfx)

            'Cache the width and height
            RClickGfxInfo.Width = RClickGfx.Size.X
            RClickGfxInfo.Height = RClickGfx.Size.Y
        End If

        QuestGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\" & "QuestLog" & GfxExt) Then
            QuestGfx = New Texture(Paths.Gui & "Main\" & "QuestLog" & GfxExt)
            QuestSprite = New Sprite(QuestGfx)

            'Cache the width and height
            QuestGfxInfo.Width = QuestGfx.Size.X
            QuestGfxInfo.Height = QuestGfx.Size.Y
        End If

        CraftGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\" & "Craft" & GfxExt) Then
            CraftGfx = New Texture(Paths.Gui & "Main\" & "Craft" & GfxExt)
            CraftSprite = New Sprite(CraftGfx)

            'Cache the width and height
            CraftGfxInfo.Width = CraftGfx.Size.X
            CraftGfxInfo.Height = CraftGfx.Size.Y
        End If

        ProgBarGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\" & "ProgBar" & GfxExt) Then
            ProgBarGfx = New Texture(Paths.Gui & "Main\" & "ProgBar" & GfxExt)
            ProgBarSprite = New Sprite(ProgBarGfx)

            'Cache the width and height
            ProgBarGfxInfo.Width = ProgBarGfx.Size.X
            ProgBarGfxInfo.Height = ProgBarGfx.Size.Y
        End If

        ChatBubbleGfxInfo = New GraphicInfo
        If File.Exists(Paths.Graphics & "Misc\ChatBubble" & GfxExt) Then
            ChatBubbleGfx = New Texture(Paths.Graphics & "Misc\ChatBubble" & GfxExt)
            ChatBubbleSprite = New Sprite(ChatBubbleGfx)
            'Cache the width and height
            ChatBubbleGfxInfo.Width = ChatBubbleGfx.Size.X
            ChatBubbleGfxInfo.Height = ChatBubbleGfx.Size.Y
        End If

        PetStatsGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\Pet" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            PetStatsGfx = New Texture(Paths.Gui & "Main\Pet" & GfxExt)
            PetStatsSprite = New Sprite(PetStatsGfx)

            'Cache the width and height
            PetStatsGfxInfo.Width = PetStatsGfx.Size.X
            PetStatsGfxInfo.Height = PetStatsGfx.Size.Y
        End If

        PetbarGfxInfo = New GraphicInfo
        If File.Exists(Paths.Gui & "Main\Petbar" & GfxExt) Then
            'Load texture first, dont care about memory streams (just use the filename)
            PetBarGfx = New Texture(Paths.Gui & "Main\Petbar" & GfxExt)
            PetBarSprite = New Sprite(PetBarGfx)

            'Cache the width and height
            PetbarGfxInfo.Width = PetBarGfx.Size.X
            PetbarGfxInfo.Height = PetBarGfx.Size.Y
        End If

        LightGfxInfo = New GraphicInfo
        If File.Exists(Paths.Graphics & "Misc\Light" & GfxExt) Then
            LightGfx = New Texture(Paths.Graphics & "Misc\Light" & GfxExt)
            LightSprite = New Sprite(LightGfx)

            'Cache the width and height
            LightGfxInfo.Width = LightGfx.Size.X
            LightGfxInfo.Height = LightGfx.Size.Y
        End If
    End Sub

    Friend Sub LoadTexture(index As Integer, texType As Byte)

        If texType = 1 Then 'tilesets
            If index <= 0 OrElse index > NumTileSets Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            TileSetTexture(index) = New Texture(Paths.Graphics & "tilesets\" & index & GfxExt)
            TileSetSprite(index) = New Sprite(TileSetTexture(index))

            'Cache the width and height
            With TileSetTextureInfo(index)
                .Width = TileSetTexture(index).Size.X
                .Height = TileSetTexture(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With

        ElseIf texType = 2 Then 'characters
            If index <= 0 OrElse index > NumCharacters Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            CharacterGfx(index) = New Texture(Paths.Graphics & "characters\" & index & GfxExt)
            CharacterSprite(index) = New Sprite(CharacterGfx(index))

            'Cache the width and height
            With CharacterGfxInfo(index)
                .Width = CharacterGfx(index).Size.X
                .Height = CharacterGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With

        ElseIf texType = 3 Then 'paperdoll
            If index <= 0 OrElse index > NumPaperdolls Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            PaperDollGfx(index) = New Texture(Paths.Graphics & "paperdolls\" & index & GfxExt)
            PaperDollSprite(index) = New Sprite(PaperDollGfx(index))

            'Cache the width and height
            With PaperDollGfxInfo(index)
                .Width = PaperDollGfx(index).Size.X
                .Height = PaperDollGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With

        ElseIf texType = 4 Then 'items
            If index <= 0 OrElse index > NumItems Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            ItemsGfx(index) = New Texture(Paths.Graphics & "items\" & index & GfxExt)
            ItemsSprite(index) = New Sprite(ItemsGfx(index))

            'Cache the width and height
            With ItemsGfxInfo(index)
                .Width = ItemsGfx(index).Size.X
                .Height = ItemsGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With

        ElseIf texType = 5 Then 'resources
            If index <= 0 OrElse index > NumResources Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            ResourcesGfx(index) = New Texture(Paths.Graphics & "resources\" & index & GfxExt)
            ResourcesSprite(index) = New Sprite(ResourcesGfx(index))

            'Cache the width and height
            With ResourcesGfxInfo(index)
                .Width = ResourcesGfx(index).Size.X
                .Height = ResourcesGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With

        ElseIf texType = 6 Then 'animations
            If index <= 0 OrElse index > NumAnimations Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            AnimationsGfx(index) = New Texture(Paths.Graphics & "animations\" & index & GfxExt)
            AnimationsSprite(index) = New Sprite(AnimationsGfx(index))

            'Cache the width and height
            With AnimationsGfxInfo(index)
                .Width = AnimationsGfx(index).Size.X
                .Height = AnimationsGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With

        ElseIf texType = 7 Then 'faces
            If index <= 0 OrElse index > NumFaces Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            FacesGfx(index) = New Texture(Paths.Graphics & "faces\" & index & GfxExt)
            FacesSprite(index) = New Sprite(FacesGfx(index))

            'Cache the width and height
            With FacesGfxInfo(index)
                .Width = FacesGfx(index).Size.X
                .Height = FacesGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With

        ElseIf texType = 8 Then 'fogs
            If index <= 0 OrElse index > NumFogs Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            FogGfx(index) = New Texture(Paths.Graphics & "fogs\" & index & GfxExt)
            FogSprite(index) = New Sprite(FogGfx(index))

            'Cache the width and height
            With FogGfxInfo(index)
                .Width = FogGfx(index).Size.X
                .Height = FogGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With

        ElseIf texType = 9 Then 'skill icons
            If index <= 0 OrElse index > NumSkillIcons Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            SkillIconsGfx(index) = New Texture(Paths.Graphics & "skillicons\" & index & GfxExt)
            SkillIconsSprite(index) = New Sprite(SkillIconsGfx(index))

            'Cache the width and height
            With SkillIconsGfxInfo(index)
                .Width = SkillIconsGfx(index).Size.X
                .Height = SkillIconsGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With

        ElseIf texType = 10 Then

        ElseIf texType = 11 Then 'projectiles
            If index <= 0 OrElse index > NumProjectiles Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            ProjectileGfx(index) = New Texture(Paths.Graphics & "projectiles\" & index & GfxExt)
            ProjectileSprite(index) = New Sprite(ProjectileGfx(index))

            'Cache the width and height
            With ProjectileGfxInfo(index)
                .Width = ProjectileGfx(index).Size.X
                .Height = ProjectileGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With

        ElseIf texType = 12 Then 'emotes
            If index <= 0 OrElse index > NumEmotes Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            EmotesGfx(index) = New Texture(Paths.Graphics & "emotes\" & index & GfxExt)
            EmotesSprite(index) = New Sprite(EmotesGfx(index))

            'Cache the width and height
            With EmotesGfxInfo(index)
                .Width = EmotesGfx(index).Size.X
                .Height = EmotesGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With

        ElseIf texType = 13 Then 'Panoramas
            If index <= 0 OrElse index > NumPanorama Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            PanoramasGfx(index) = New Texture(Paths.Graphics & "panoramas\" & index & GfxExt)
            PanoramasSprite(index) = New Sprite(PanoramasGfx(index))

            'Cache the width and height
            With PanoramasGfxInfo(index)
                .Width = PanoramasGfx(index).Size.X
                .Height = PanoramasGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With
        ElseIf texType = 14 Then 'Parallax
            If index <= 0 OrElse index > NumParallax Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            ParallaxGfx(index) = New Texture(Paths.Graphics & "parallax\" & index & GfxExt)
            ParallaxSprite(index) = New Sprite(ParallaxGfx(index))

            'Cache the width and height
            With ParallaxGfxInfo(index)
                .Width = ParallaxGfx(index).Size.X
                .Height = ParallaxGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With
        ElseIf texType = 15 Then 'Pictures
            If index <= 0 OrElse index > NumPictures Then Exit Sub

            'Load texture first, dont care about memory streams (just use the filename)
            PictureGfx(index) = New Texture(Paths.Graphics & "pictures\" & index & GfxExt)
            PictureSprite(index) = New Sprite(PictureGfx(index))

            'Cache the width and height
            With PictureGfxInfo(index)
                .Width = PictureGfx(index).Size.X
                .Height = PictureGfx(index).Size.Y
                .IsLoaded = True
                .TextureTimer = GetTickCount() + 100000
            End With
        End If
    End Sub

#End Region

    Friend Sub DrawEmotes(x2 As Integer, y2 As Integer, sprite As Integer)
        Dim rec As Rectangle
        Dim x As Integer, y As Integer, anim As Integer
        'Dim width As Integer, height As Integer

        If sprite < 1 OrElse sprite > NumEmotes Then Exit Sub

        If EmotesGfxInfo(sprite).IsLoaded = False Then
            LoadTexture(sprite, 12)
        End If

        'seeying we still use it, lets update timer
        With EmotesGfxInfo(sprite)
            .TextureTimer = GetTickCount() + 100000
        End With

        If ShowAnimLayers = True Then
            anim = 1
        Else
            anim = 0
        End If

        With rec
            .Y = 0
            .Height = PicX
            .X = anim * (EmotesGfxInfo(sprite).Width / 2)
            .Width = (EmotesGfxInfo(sprite).Width / 2)
        End With

        x = ConvertMapX(x2)
        y = ConvertMapY(y2) - (PicY + 16)

        RenderSprite(EmotesSprite(sprite), GameWindow, x, y, rec.X, rec.Y, rec.Width, rec.Height)
    End Sub

    Sub DrawChat()
        Dim i As Integer, x As Integer, y As Integer
        Dim text As String

        'first draw back image
        RenderSprite(ChatWindowSprite, GameWindow, ChatWindowX, ChatWindowY - 2, 0, 0, ChatWindowGfxInfo.Width,
                     ChatWindowGfxInfo.Height)

        y = 45
        x = 45

        FirstLineindex = (Chat.Count - MaxChatDisplayLines) - ScrollMod _
        'First element is the 5th from the last in the list
        If FirstLineindex < 0 Then FirstLineindex = 0 _
        'if the list has less than 5 elements, the first is the 0th index or first element

        LastLineindex = (FirstLineindex + MaxChatDisplayLines) ' - ScrollMod
        If (LastLineindex >= Chat.Count) Then LastLineindex = Chat.Count - 1 _
        'Based off of index 0, so the last element should be Chat.Count -1

        'only loop tru last entries
        For i = FirstLineindex To LastLineindex
            text = Chat(i).Text

            If text <> "" Then ' or not
                DrawText(ChatWindowX + x, ChatWindowY + y, text, GetSfmlColor(Chat(i).Color), Color.Black, GameWindow)
                y = y + ChatLineSpacing + 1
            End If

        Next

        'My Text
        'first draw back image
        RenderSprite(MyChatWindowSprite, GameWindow, MyChatX, MyChatY - 5, 0, 0, MyChatWindowGfxInfo.Width,
                     MyChatWindowGfxInfo.Height)

        If Len(ChatInput.CurrentMessage) > 0 Then
            Dim subText As String = ChatInput.CurrentMessage
            While GetTextWidth(subText) > MyChatWindowGfxInfo.Width - ChatEntryPadding
                subText = subText.Substring(1)
            End While
            DrawText(MyChatX + 5, MyChatY - 3, subText, Color.White, Color.Black, GameWindow)
        End If
    End Sub

    Friend Sub DrawButton(text As String, destX As Integer, destY As Integer, hover As Byte)
        If hover = 0 Then
            RenderSprite(ButtonSprite, GameWindow, destX, destY, 0, 0, ButtonGfxInfo.Width, ButtonGfxInfo.Height)

            DrawText(destX + (ButtonGfxInfo.Width \ 2) - (GetTextWidth(text) \ 2),
                     destY + (ButtonGfxInfo.Height \ 2) - (FontSize \ 2), text, Color.White, Color.Black, GameWindow)
        Else
            RenderSprite(ButtonHoverSprite, GameWindow, destX, destY, 0, 0, ButtonHoverGfxInfo.Width,
                         ButtonHoverGfxInfo.Height)

            DrawText(destX + (ButtonHoverGfxInfo.Width \ 2) - (GetTextWidth(text) \ 2),
                     destY + (ButtonHoverGfxInfo.Height \ 2) - (FontSize \ 2), text, Color.White, Color.Black, GameWindow)
        End If
    End Sub

    Friend Sub RenderSprite(tmpSprite As Sprite, target As RenderWindow, destX As Integer, destY As Integer,
                            sourceX As Integer, sourceY As Integer,
                            sourceWidth As Integer, sourceHeight As Integer, Optional red As Byte = 255, Optional green As Byte = 255, Optional blue As Byte = 255, Optional alpha As Byte = 255)

        If tmpSprite Is Nothing Then Exit Sub

        tmpSprite.TextureRect = New IntRect(sourceX, sourceY, sourceWidth, sourceHeight)
        tmpSprite.Position = New Vector2f(destX, destY)
        tmpSprite.Color = New Color(red, green, blue, alpha)
        target.Draw(tmpSprite)
    End Sub

    Friend Sub RenderTextures(txture As Texture, target As RenderWindow, dX As Single, dY As Single, sx As Single,
                              sy As Single, dWidth As Single, dHeight As Single, sWidth As Single, sHeight As Single)
        Dim tmpImage = New Sprite(txture) With {
                .TextureRect = New IntRect(sx, sy, sWidth, sHeight),
                .Scale = New Vector2f(dWidth / sWidth, dHeight / sHeight),
                .Position = New Vector2f(dX, dY)
                }
        target.Draw(tmpImage)
    End Sub

    Friend Sub DrawDirections(x As Integer, y As Integer)
        Dim rec As Rectangle, i As Integer

        ' render grid
        rec.Y = 24
        rec.X = 0
        rec.Width = 32
        rec.Height = 32
        RenderSprite(DirectionsSprite, GameWindow, ConvertMapX(x * PicX), ConvertMapY(y * PicY), rec.X, rec.Y, rec.Width,
                     rec.Height)

        ' render dir blobs
        For i = 1 To 4
            rec.X = (i - 1) * 8
            rec.Width = 8
            ' find out whether render blocked or not
            If Not IsDirBlocked(Map.Tile(x, y).DirBlock, (i)) Then
                rec.Y = 8
            Else
                rec.Y = 16
            End If
            rec.Height = 8

            RenderSprite(DirectionsSprite, GameWindow, ConvertMapX(x * PicX) + DirArrowX(i),
                         ConvertMapY(y * PicY) + DirArrowY(i), rec.X, rec.Y, rec.Width, rec.Height)
        Next
    End Sub

    Friend Function ConvertMapX(x As Integer) As Integer
        ConvertMapX = x - (TileView.Left * PicX) - Camera.Left
    End Function

    Friend Function ConvertMapY(y As Integer) As Integer
        ConvertMapY = y - (TileView.Top * PicY) - Camera.Top
    End Function

    Friend Sub DrawPaperdoll(x2 As Integer, y2 As Integer, sprite As Integer, anim As Integer, spritetop As Integer)
        Dim rec As Rectangle
        Dim x As Integer, y As Integer
        Dim width As Integer, height As Integer

        If sprite < 1 OrElse sprite > NumPaperdolls Then Exit Sub

        If PaperDollGfxInfo(sprite).IsLoaded = False Then
            LoadTexture(sprite, 3)
        End If

        ' we use it, lets update timer
        With PaperDollGfxInfo(sprite)
            .TextureTimer = GetTickCount() + 100000
        End With

        With rec
            .Y = spritetop * (PaperDollGfxInfo(sprite).Height / 4)
            .Height = (PaperDollGfxInfo(sprite).Height / 4)
            .X = anim * (PaperDollGfxInfo(sprite).Width / 4)
            .Width = (PaperDollGfxInfo(sprite).Width / 4)
        End With

        x = ConvertMapX(x2)
        y = ConvertMapY(y2)
        width = (rec.Right - rec.Left)
        height = (rec.Bottom - rec.Top)

        RenderSprite(PaperDollSprite(sprite), GameWindow, x, y, rec.X, rec.Y, rec.Width, rec.Height)
    End Sub

    Friend Sub DrawNpc(mapNpcNum As Integer)
        Dim anim As Byte
        Dim x As Integer
        Dim y As Integer
        Dim sprite As Integer, spriteleft As Integer
        Dim destrec As Rectangle
        Dim srcrec As Rectangle
        Dim attackspeed As Integer

        If MapNpc(mapNpcNum).Num = 0 Then Exit Sub ' no npc set

        If MapNpc(mapNpcNum).X < TileView.Left OrElse MapNpc(mapNpcNum).X > TileView.Right Then Exit Sub
        If MapNpc(mapNpcNum).Y < TileView.Top OrElse MapNpc(mapNpcNum).Y > TileView.Bottom Then Exit Sub

        StreamNpc(MapNpc(mapNpcNum).Num)

        sprite = Npc(MapNpc(mapNpcNum).Num).Sprite

        If sprite < 1 OrElse sprite > NumCharacters Then Exit Sub

        attackspeed = 1000

        ' Reset frame
        anim = 0

        ' Check for attacking animation
        If MapNpc(mapNpcNum).AttackTimer + (attackspeed / 2) > GetTickCount() Then
            If MapNpc(mapNpcNum).Attacking = 1 Then
                anim = 3
            End If
        Else
            ' If not attacking, walk normally
            Select Case MapNpc(mapNpcNum).Dir
                Case DirectionType.Up
                    If (MapNpc(mapNpcNum).YOffset > 8) Then anim = MapNpc(mapNpcNum).Steps
                Case DirectionType.Down
                    If (MapNpc(mapNpcNum).YOffset < -8) Then anim = MapNpc(mapNpcNum).Steps
                Case DirectionType.Left
                    If (MapNpc(mapNpcNum).XOffset > 8) Then anim = MapNpc(mapNpcNum).Steps
                Case DirectionType.Right
                    If (MapNpc(mapNpcNum).XOffset < -8) Then anim = MapNpc(mapNpcNum).Steps
            End Select
        End If

        ' Check to see if we want to stop making him attack
        With MapNpc(mapNpcNum)
            If .AttackTimer + attackspeed < GetTickCount() Then
                .Attacking = 0
                .AttackTimer = 0
            End If
        End With

        ' Set the left
        Select Case MapNpc(mapNpcNum).Dir
            Case DirectionType.Up
                spriteleft = 3
            Case DirectionType.Right
                spriteleft = 2
            Case DirectionType.Down
                spriteleft = 0
            Case DirectionType.Left
                spriteleft = 1
        End Select

        srcrec = New Rectangle((anim) * (CharacterGfxInfo(sprite).Width / 4), spriteleft * (CharacterGfxInfo(sprite).Height / 4),
                               (CharacterGfxInfo(sprite).Width / 4), (CharacterGfxInfo(sprite).Height / 4))

        ' Calculate the X
        x = MapNpc(mapNpcNum).X * PicX + MapNpc(mapNpcNum).XOffset - ((CharacterGfxInfo(sprite).Width / 4 - 32) / 2)

        ' Is the player's height more than 32..?
        If (CharacterGfxInfo(sprite).Height / 4) > 32 Then
            ' Create a 32 pixel offset for larger sprites
            y = MapNpc(mapNpcNum).Y * PicY + MapNpc(mapNpcNum).YOffset - ((CharacterGfxInfo(sprite).Height / 4) - 32)
        Else
            ' Proceed as normal
            y = MapNpc(mapNpcNum).Y * PicY + MapNpc(mapNpcNum).YOffset
        End If

        destrec = New Rectangle(x, y, CharacterGfxInfo(sprite).Width / 4, CharacterGfxInfo(sprite).Height / 4)

        DrawCharacter(sprite, x, y, srcrec)
    End Sub

    Friend Sub DrawMapItem(itemnum As Integer)
        Dim srcrec As Rectangle, destrec As Rectangle
        Dim picNum As Integer
        Dim x As Integer, y As Integer

        StreamItem(MapItem(itemnum).Num)

        picNum = Item(MapItem(itemnum).Num).Pic

        If picNum < 1 OrElse picNum > NumItems Then Exit Sub

        If ItemsGfxInfo(picNum).IsLoaded = False Then
            LoadTexture(picNum, 4)
        End If

        'seeying we still use it, lets update timer
        With ItemsGfxInfo(picNum)
            .TextureTimer = GetTickCount() + 100000
        End With

        With MapItem(itemnum)
            If .X < TileView.Left OrElse .X > TileView.Right Then Exit Sub
            If .Y < TileView.Top OrElse .Y > TileView.Bottom Then Exit Sub
        End With

        If ItemsGfxInfo(picNum).Width > 32 Then ' has more than 1 frame
            srcrec = New Rectangle((MapItem(itemnum).Frame * 32), 0, 32, 32)
            destrec = New Rectangle(ConvertMapX(MapItem(itemnum).X * PicX), ConvertMapY(MapItem(itemnum).Y * PicY), 32, 32)
        Else
            srcrec = New Rectangle(0, 0, PicX, PicY)
            destrec = New Rectangle(ConvertMapX(MapItem(itemnum).X * PicX), ConvertMapY(MapItem(itemnum).Y * PicY), PicX,
                                    PicY)
        End If

        x = ConvertMapX(MapItem(itemnum).X * PicX)
        y = ConvertMapY(MapItem(itemnum).Y * PicY)

        RenderSprite(ItemsSprite(picNum), GameWindow, x, y, srcrec.X, srcrec.Y, srcrec.Width, srcrec.Height)
    End Sub

    Friend Sub DrawCharacter(sprite As Integer, x2 As Integer, y2 As Integer, rec As Rectangle)
        Dim x As Integer
        Dim y As Integer
        Dim width As Integer
        Dim height As Integer

        If sprite < 1 OrElse sprite > NumCharacters Then Exit Sub

        If CharacterGfxInfo(sprite).IsLoaded = False Then
            LoadTexture(sprite, 2)
        End If

        'seeying we still use it, lets update timer
        With CharacterGfxInfo(sprite)
            .TextureTimer = GetTickCount() + 100000
        End With

        x = ConvertMapX(x2)
        y = ConvertMapY(y2)
        width = (rec.Width)
        height = (rec.Height)

        RenderSprite(CharacterSprite(sprite), GameWindow, x, y, rec.X, rec.Y, rec.Width, rec.Height)
    End Sub

    Friend Sub DrawBlood(index As Integer)
        Dim dest = New Point(FrmGame.PointToScreen(FrmGame.picscreen.Location))
        Dim srcrec As Rectangle
        Dim destrec As Rectangle
        Dim x As Integer
        Dim y As Integer

        With Blood(index)
            If .X < TileView.Left OrElse .X > TileView.Right Then Exit Sub
            If .Y < TileView.Top OrElse .Y > TileView.Bottom Then Exit Sub

            ' check if we should be seeing it
            If .Timer + 20000 < GetTickCount() Then Exit Sub

            x = ConvertMapX(Blood(index).X * PicX)
            y = ConvertMapY(Blood(index).Y * PicY)

            srcrec = New Rectangle((.Sprite - 1) * PicX, 0, PicX, PicY)

            destrec = New Rectangle(ConvertMapX(.X * PicX), ConvertMapY(.Y * PicY), PicX, PicY)

            RenderSprite(BloodSprite, GameWindow, x, y, srcrec.X, srcrec.Y, srcrec.Width, srcrec.Height)

        End With
    End Sub

    Friend Function IsValidMapPoint(x As Integer, y As Integer) As Boolean
        IsValidMapPoint = False

        If x < 0 Then Exit Function
        If y < 0 Then Exit Function
        If x > Map.MaxX Then Exit Function
        If y > Map.MaxY Then Exit Function
        IsValidMapPoint = True
    End Function

    Friend Sub UpdateCamera()
        Dim offsetX As Integer, offsetY As Integer
        Dim startX As Integer, startY As Integer
        Dim endX As Integer, endY As Integer

        offsetX = Player(Myindex).XOffset + PicX
        offsetY = Player(Myindex).YOffset + PicY

        If Settings.CameraType = 1 Then
            startX = GetPlayerX(Myindex) - ScreenMapx
            startY = GetPlayerY(Myindex) - ScreenMapy
        Else
            startX = GetPlayerX(Myindex) - ((ScreenMapx + 1) / 2) - 1
            startY = GetPlayerY(Myindex) - ((ScreenMapy + 1) / 2) - 1
        End If

        If startX < 0 Then
            offsetX = 0

            If startX = -1 Then
                If Player(Myindex).XOffset > 0 Then
                    offsetX = Player(Myindex).XOffset
                End If
            End If

            startX = 0
        End If

        If startY < 0 Then
            offsetY = 0

            If startY = -1 Then
                If Player(Myindex).YOffset > 0 Then
                    offsetY = Player(Myindex).YOffset
                End If
            End If

            startY = 0
        End If

        endX = startX + (ScreenMapx + 1) + 1
        endY = startY + (ScreenMapy + 1) + 1

        If endX > Map.MaxX Then
            offsetX = 32

            If endX = Map.MaxX + 1 Then
                If Player(Myindex).XOffset < 0 Then
                    offsetX = Player(Myindex).XOffset + PicX
                End If
            End If

            endX = Map.MaxX
            startX = endX - ScreenMapx - 1
        End If

        If endY > Map.MaxY Then
            offsetY = 32

            If endY = Map.MaxY + 1 Then
                If Player(Myindex).YOffset < 0 Then
                    offsetY = Player(Myindex).YOffset + PicY
                End If
            End If

            endY = Map.MaxY
            startY = endY - ScreenMapy - 1
        End If

        With TileView
            .Top = startY
            .Bottom = endY
            .Left = startX
            .Right = endX
        End With

        With Camera
            .Y = offsetY
            .X = offsetX
            If Settings.CameraType = 1 Then
                .Height = .Top + ScreenY + PicY
                .Width = .Left + ScreenX + PicX
            Else
                .Height = ScreenY + PicY
                .Width = ScreenX + PicX
            End If
        End With

        UpdateDrawMapName()
    End Sub

    Sub ClearGfx()

        'clear tilesets
        For i = 0 To NumTileSets
            If TileSetTextureInfo(i).IsLoaded Then
                If TileSetTextureInfo(i).TextureTimer < GetTickCount() Then
                    TileSetTexture(i).Dispose()
                    TileSetSprite(i).Dispose()
                    TileSetTextureInfo(i).IsLoaded = False
                    TileSetTextureInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'clear characters
        For i = 0 To NumCharacters
            If CharacterGfxInfo(i).IsLoaded Then
                If CharacterGfxInfo(i).TextureTimer < GetTickCount() Then
                    CharacterGfx(i).Dispose()
                    CharacterSprite(i).Dispose()
                    CharacterGfxInfo(i).IsLoaded = False
                    CharacterGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'clear paperdoll
        For i = 0 To NumPaperdolls
            If PaperDollGfxInfo(i).IsLoaded Then
                If PaperDollGfxInfo(i).TextureTimer < GetTickCount() Then
                    PaperDollGfx(i).Dispose()
                    PaperDollSprite(i).Dispose()
                    PaperDollGfxInfo(i).IsLoaded = False
                    PaperDollGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'clear items
        For i = 0 To NumItems
            If ItemsGfxInfo(i).IsLoaded Then
                If ItemsGfxInfo(i).TextureTimer < GetTickCount() Then
                    ItemsGfx(i).Dispose()
                    ItemsSprite(i).Dispose()
                    ItemsGfxInfo(i).IsLoaded = False
                    ItemsGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'clear resources
        For i = 0 To NumResources
            If ResourcesGfxInfo(i).IsLoaded Then
                If ResourcesGfxInfo(i).TextureTimer < GetTickCount() Then
                    ResourcesGfx(i).Dispose()
                    ResourcesSprite(i).Dispose()
                    ResourcesGfxInfo(i).IsLoaded = False
                    ResourcesGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'animations
        For i = 0 To NumAnimations
            If AnimationsGfxInfo(i).IsLoaded Then
                If AnimationsGfxInfo(i).TextureTimer < GetTickCount() Then
                    AnimationsGfx(i).Dispose()
                    AnimationsGfxInfo(i).IsLoaded = False
                    AnimationsGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'clear faces
        For i = 0 To NumFaces
            If FacesGfxInfo(i).IsLoaded Then
                If FacesGfxInfo(i).TextureTimer < GetTickCount() Then
                    FacesGfx(i).Dispose()
                    FacesSprite(i).Dispose()
                    FacesGfxInfo(i).IsLoaded = False
                    FacesGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'clear fogs
        For i = 0 To NumFogs
            If FogGfxInfo(i).IsLoaded Then
                If FogGfxInfo(i).TextureTimer < GetTickCount() Then
                    FogGfx(i).Dispose()
                    FogGfxInfo(i).IsLoaded = False
                    FogGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'clear SkillIcons
        For i = 0 To NumSkillIcons
            If SkillIconsGfxInfo(i).IsLoaded Then
                If SkillIconsGfxInfo(i).TextureTimer < GetTickCount() Then
                    SkillIconsGfx(i).Dispose()
                    SkillIconsSprite(i).Dispose()
                    SkillIconsGfxInfo(i).IsLoaded = False
                    SkillIconsGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next


        'clear Projectiles
        For i = 0 To NumProjectiles
            If ProjectileGfxInfo(i).IsLoaded Then
                If ProjectileGfxInfo(i).TextureTimer < GetTickCount() Then
                    ProjectileGfx(i).Dispose()
                    ProjectileSprite(i).Dispose()
                    ProjectileGfxInfo(i).IsLoaded = False
                    ProjectileGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'clear Emotes
        For i = 0 To NumEmotes
            If EmotesGfxInfo(i).IsLoaded Then
                If EmotesGfxInfo(i).TextureTimer < GetTickCount() Then
                    EmotesGfx(i).Dispose()
                    EmotesSprite(i).Dispose()
                    EmotesGfxInfo(i).IsLoaded = False
                    EmotesGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'clear Panoramas
        For i = 0 To NumPanorama
            If PanoramasGfxInfo(i).IsLoaded Then
                If PanoramasGfxInfo(i).TextureTimer < GetTickCount() Then
                    PanoramasGfx(i).Dispose()
                    PanoramasSprite(i).Dispose()
                    PanoramasGfxInfo(i).IsLoaded = False
                    PanoramasGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'clear Parallax
        For i = 0 To NumParallax
            If ParallaxGfxInfo(i).IsLoaded Then
                If ParallaxGfxInfo(i).TextureTimer < GetTickCount() Then
                    ParallaxGfx(i).Dispose()
                    ParallaxSprite(i).Dispose()
                    ParallaxGfxInfo(i).IsLoaded = False
                    ParallaxGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next

        'clear pictures
        For i = 0 To NumPictures
            If PictureGfxInfo(i).IsLoaded Then
                If PictureGfxInfo(i).TextureTimer < GetTickCount() Then
                    PictureGfx(i).Dispose()
                    PictureSprite(i).Dispose()
                    PictureGfxInfo(i).IsLoaded = False
                    PictureGfxInfo(i).TextureTimer = 0
                End If
            End If
        Next
    End Sub

    Friend Sub Render_Graphics()
        Dim x As Integer, y As Integer, I As Integer

        'Don't Render IF
        If FrmGame.WindowState = FormWindowState.Minimized Then Exit Sub
        If GettingMap Then Exit Sub

        'update view around player
        UpdateCamera()

        'Clear each of our render targets
        GameWindow.DispatchEvents()
        GameWindow.Clear(Color.Black)

        'If CurMouseX > 0 AndAlso CurMouseX <= GameWindow.Size.X Then
        '    If CurMouseY > 0 AndAlso CurMouseY <= GameWindow.Size.Y Then
        '        GameWindow.SetMouseCursorVisible(False)
        '    End If
        'End If

        If NumPanorama > 0 AndAlso Map.Panorama > 0 Then
            DrawPanorama(Map.Panorama)
        End If

        If NumParallax > 0 AndAlso Map.Parallax > 0 Then
            DrawParallax(Map.Parallax)
        End If

        ' Draw lower tiles
        If NumTileSets > 0 Then
            For x = TileView.Left To TileView.Right + 1
                For y = TileView.Top To TileView.Bottom + 1
                    If IsValidMapPoint(x, y) Then
                        DrawMapTile(x, y)
                    End If
                Next
            Next
        End If

        ' events
        If Editor <> EditorType.Map Then
            If Map.CurrentEvents > 0 AndAlso Map.CurrentEvents <= Map.EventCount Then
                For I = 0 To Map.CurrentEvents
                    If Map.MapEvents(I).Position = 0 Then
                        DrawEvent(I)
                    End If
                Next
            End If
        End If

        'blood
        For I = 0 To Byte.MaxValue
            DrawBlood(I)
        Next

        ' Draw out the items
        If NumItems > 0 Then
            For I = 1 To MAX_MAP_ITEMS
                If MapItem(I).Num > 0 Then
                    DrawMapItem(I)
                End If
            Next
        End If

        ' draw animations
        If NumAnimations > 0 Then
            For I = 0 To Byte.MaxValue
                If AnimInstance(I).Used(0) Then
                    DrawAnimation(I, 0)
                End If
            Next
        End If

        ' Y-based render. Renders Players, Npcs and Resources based on Y-axis.
        For y = 0 To Map.MaxY

            If NumCharacters > 0 Then
                ' Players
                For I = 1 To MAX_PLAYERS
                    If IsPlaying(I) AndAlso GetPlayerMap(I) = GetPlayerMap(Myindex) Then
                        If Player(I).Y = y Then
                            DrawPlayer(I)
                        End If

                        If PetAlive(I) Then
                            If Player(I).Pet.Y = y Then
                                DrawPet(I)
                            End If
                        End If
                    End If
                Next

                ' Npcs
                For i = 1 To MAX_MAP_NPCS
                    If MapNpc(I).Y = y Then
                        DrawNpc(I)
                    End If
                Next

                ' events
                If Editor <> EditorType.Map Then
                    If Map.CurrentEvents > 0 AndAlso Map.CurrentEvents <= Map.EventCount Then
                        For I = 0 To Map.CurrentEvents
                            If Map.MapEvents(I).Position = 1 Then
                                If y = Map.MapEvents(I).Y Then
                                    DrawEvent(I)
                                End If
                            End If
                        Next
                    End If
                End If

                ' Draw the target icon
                If MyTarget > 0 Then
                    If MyTargetType = TargetType.Player Then
                        DrawTarget(Player(MyTarget).X * 32 - 16 + Player(MyTarget).XOffset,
                                   Player(MyTarget).Y * 32 + Player(MyTarget).YOffset)
                    ElseIf MyTargetType = TargetType.Npc Then
                        DrawTarget(MapNpc(MyTarget).X * 32 - 16 + MapNpc(MyTarget).XOffset,
                                   MapNpc(MyTarget).Y * 32 + MapNpc(MyTarget).YOffset)
                    ElseIf MyTargetType = TargetType.Pet Then
                        DrawTarget(Player(MyTarget).Pet.X * 32 - 16 + Player(MyTarget).Pet.XOffset,
                                   (Player(MyTarget).Pet.Y * 32) + Player(MyTarget).Pet.YOffset)
                    End If
                End If

                For I = 1 To MAX_PLAYERS
                    If IsPlaying(I) Then
                        If Player(I).Map = Player(Myindex).Map Then
                            If CurX = Player(I).X AndAlso CurY = Player(I).Y Then
                                If MyTargetType = TargetType.Player AndAlso MyTarget = I Then
                                    ' dont render lol
                                Else
                                    DrawHover(Player(I).X * 32 - 16, Player(I).Y * 32 + Player(I).YOffset)
                                End If
                            End If

                        End If
                    End If
                Next
            End If

            ' Resources
            If NumResources > 0 Then
                If ResourcesInit Then
                    If ResourceIndex > 0 Then
                        For I = 0 To ResourceIndex
                            If MapResource(I).Y = y Then
                                DrawMapResource(I)
                            End If
                        Next
                    End If
                End If
            End If
        Next

        ' animations
        If NumAnimations > 0 Then
            For I = 0 To Byte.MaxValue
                If AnimInstance(I).Used(1) Then
                    DrawAnimation(I, 1)
                End If
            Next
        End If

        'projectiles
        If NumProjectiles > 0 Then
            For i = 1 To MAX_PROJECTILES
                If MapProjectile(I).ProjectileNum > 0 Then
                    DrawProjectile(I)
                End If
            Next
        End If

        'events
        If Map.CurrentEvents > 0 AndAlso Map.CurrentEvents <= Map.EventCount Then
            For I = 0 To Map.CurrentEvents
                If Map.MapEvents(I).Position = 2 Then
                    DrawEvent(I)
                End If
            Next
        End If

        ' blit out upper tiles
        If NumTileSets > 0 Then
            For x = TileView.Left To TileView.Right + 1
                For y = TileView.Top To TileView.Bottom + 1
                    If IsValidMapPoint(x, y) Then
                        DrawMapFringeTile(x, y)
                    End If
                Next
            Next
        End If

        DrawNight()
        DrawWeather()
        DrawThunderEffect()
        DrawMapTint()

        ' Draw out a square at mouse cursor
        If MapGrid = True AndAlso Editor = EditorType.Map Then
            DrawGrid()
        End If

        If frmEditor_Map.tabpages.SelectedTab Is frmEditor_Map.tpDirBlock Then
            For x = TileView.Left To TileView.Right
                For y = TileView.Top To TileView.Bottom
                    If IsValidMapPoint(x, y) Then
                        DrawDirections(x, y)
                    End If
                Next
            Next
        End If

        If Editor = EditorType.Map Then
            DrawTileOutline()
            If EyeDropper = True Then 
                DrawEyeDropper()
            End If
        End If

        ' draw cursor, player X and Y locations
        If BLoc Then
            DrawText(1, HudWindowY + HudPanelGfxInfo.Height + 1,
                     Trim$(String.Format(Language.Game.MapCurLoc, CurX, CurY)), Color.Yellow, Color.Black, GameWindow)
            DrawText(1, HudWindowY + HudPanelGfxInfo.Height + 15,
                     Trim$(String.Format(Language.Game.MapLoc, GetPlayerX(Myindex), GetPlayerY(Myindex))), Color.Yellow,
                     Color.Black, GameWindow)
            DrawText(1, HudWindowY + HudPanelGfxInfo.Height + 30,
                     Trim$(String.Format(Language.Game.MapCurMap, GetPlayerMap(Myindex))), Color.Yellow, Color.Black,
                     GameWindow)
        End If

        ' draw player names
        For I = 1 To MAX_PLAYERS
            If IsPlaying(I) AndAlso GetPlayerMap(I) = GetPlayerMap(Myindex) Then
                DrawPlayerName(I)
                If PetAlive(I) Then
                    DrawPlayerPetName(I)
                End If
            End If
        Next

        'draw event names
        For I = 0 To Map.CurrentEvents
            If Map.MapEvents(I).Visible = 1 Then
                If Map.MapEvents(I).ShowName = 1 Then
                    DrawEventName(I)
                End If
            End If
        Next

        ' draw npc names
        For i = 1 To MAX_MAP_NPCS
            If MapNpc(I).Num > 0 Then
                DrawNpcName(I)
            End If
        Next

        If CurrentFog > 0 Then
            DrawFog()
        End If

        DrawPicture()

        ' draw the messages
        For I = 1 To Byte.MaxValue
            If ChatBubble(I).Active Then
                DrawChatBubble(I)
            End If
        Next

        'action msg
        For I = 1 To Byte.MaxValue
            DrawActionMsg(I)
        Next

        ' Blit out map attributes
        If Editor = EditorType.Map Then
            DrawMapAttributes()
        End If

        If Editor = EditorType.Map AndAlso frmEditor_Map.tabpages.SelectedTab Is frmEditor_Map.tpEvents Then
            DrawEvents()
            EditorEvent_DrawGraphic()
        End If

        'draw hp and casting bars
        DrawBars()

        'party
        DrawParty()

        'Render GUI
        DrawGui()

        DrawMapFade()

        'and finally show everything on screen
        GameWindow.Display()
    End Sub

    Friend Sub DrawPanorama(index As Integer)
        If Map.Moral = MapMoralType.Indoors Then Exit Sub

        If index < 1 OrElse index > NumParallax Then Exit Sub

        If PanoramasGfxInfo(index).IsLoaded = False Then
            LoadTexture(index, 13)
        End If

        ' we use it, lets update timer
        With PanoramasGfxInfo(index)
            .TextureTimer = GetTickCount() + 100000
        End With

        PanoramasSprite(index).TextureRect = New IntRect(0, 0, GameWindow.Size.X, GameWindow.Size.Y)
        PanoramasSprite(index).Position = New Vector2f(0, 0)

        GameWindow.Draw(PanoramasSprite(index))
    End Sub

    Friend Sub DrawParallax(index As Integer)
        Dim horz = 0
        Dim vert = 0

        If Map.Moral = MapMoralType.Indoors Then Exit Sub

        If index < 1 OrElse index > NumParallax Then Exit Sub
        If ParallaxGfxInfo(index).IsLoaded = False Then
            LoadTexture(index, 14)
        End If

        ' we use it, lets update timer
        With ParallaxGfxInfo(index)
            .TextureTimer = GetTickCount() + 100000
        End With
        horz = ConvertMapX(GetPlayerX(Myindex))
        vert = ConvertMapY(GetPlayerY(Myindex))

        ParallaxSprite(index).Position = New Vector2f((horz * 2.5) - 50, (vert * 2.5) - 50)

        GameWindow.Draw(ParallaxSprite(index))
    End Sub

    Friend Sub DrawPicture()
        Dim index As Integer

        index = Picture.Index

        If index < 1 Or index > NumPictures Then Exit Sub

        If PictureGfxInfo(index).IsLoaded = False Then
            LoadTexture(index, 15)
        End If

        ' we use it, lets update timer
        With PictureGfxInfo(index)
            .TextureTimer = GetTickCount() + 100000
        End With

        PictureSprite(index).TextureRect = New IntRect(0, 0, GameWindow.Size.X, GameWindow.Size.Y)

        Select Case Picture.SpriteType
            Case 0 ' Top Left
                PictureSprite(index).Position = New Vector2f(0 - Picture.xOffset, 0 - Picture.yOffset)
            Case 1 ' Center Screen
                PictureSprite(index).Position = New Vector2f(GameWindow.Size.X / 2 - PictureGfxInfo(index).Width / 2 - Picture.xOffset, GameWindow.Size.Y / 2 - PictureGfxInfo(index).Height / 2)
            Case 2 ' Center Event
                If Map.CurrentEvents < Picture.EventId Then
                    Picture.EventId = 0
                    Picture.Index = 0
                    Picture.SpriteType = 0
                    Picture.xOffset = 0
                    Picture.yOffset = 0
                    Exit Sub
                End If
                PictureSprite(index).Position = New Vector2f(ConvertMapX(Map.MapEvents(Picture.EventId).X * 32) / 2 - Picture.xOffset, ConvertMapY(Map.MapEvents(Picture.EventId).Y * 32) / 2 - Picture.yOffset)
            Case 3 ' Center Player
                PictureSprite(index).Position = New Vector2f(ConvertMapX(Player(Myindex).X * 32) / 2 - Picture.xOffset, ConvertMapY(Player(Myindex).Y * 32) / 2 - Picture.yOffset)
        End Select

        GameWindow.Draw(PictureSprite(index))
    End Sub

    Friend Sub DrawBars()
        Dim tmpY As Integer
        Dim tmpX As Integer
        Dim barWidth As Integer
        Dim rec(1) As Rectangle

        If GettingMap Then Exit Sub

        ' check for casting time bar
        If SkillBuffer > 0 Then
            ' lock to player
            tmpX = GetPlayerX(Myindex) * PicX + Player(Myindex).XOffset
            tmpY = GetPlayerY(Myindex) * PicY + Player(Myindex).YOffset + 35
            If Skill(Player(Myindex).Skill(SkillBuffer).Num).CastTime = 0 Then _
                Skill(Player(Myindex).Skill(SkillBuffer).Num).CastTime = 1
            ' calculate the width to fill
            barWidth =
                ((GetTickCount() - SkillBufferTimer) /
                 ((GetTickCount() - SkillBufferTimer) + (Skill(Player(Myindex).Skill(SkillBuffer).Num).CastTime * 1000)) *
                 64)
            ' draw bars
            rec(1) = New Rectangle(ConvertMapX(tmpX), ConvertMapY(tmpY), barWidth, 4)
            Dim rectShape As New RectangleShape(New Vector2f(barWidth, 4)) With {
                    .Position = New Vector2f(ConvertMapX(tmpX), ConvertMapY(tmpY)),
                    .FillColor = Color.Cyan
                    }
            GameWindow.Draw(rectShape)
        End If

        If Settings.ShowNpcBar = 1 Then
            ' check for hp bar
            For i = 1 To MAX_MAP_NPCS
                If Map.Npc Is Nothing Then Exit Sub
                If Map.Npc(i) > 0 And Map.Npc(i) <= MAX_NPCS And MapNpc(i).Num > 0 And MapNpc(i).Num <= MAX_NPCS Then
                    If _
                        Npc(MapNpc(i).Num).Behaviour = NpcBehavior.AttackOnSight OrElse
                        Npc(MapNpc(i).Num).Behaviour = NpcBehavior.AttackWhenAttacked OrElse
                        Npc(MapNpc(i).Num).Behaviour = NpcBehavior.Guard Then
                        ' lock to npc
                        tmpX = MapNpc(i).X * PicX + MapNpc(i).XOffset
                        tmpY = MapNpc(i).Y * PicY + MapNpc(i).YOffset + 35
                        If MapNpc(i).Vital(VitalType.HP) > 0 Then
                            ' calculate the width to fill
                            barWidth = ((MapNpc(i).Vital(VitalType.HP) / (Npc(MapNpc(i).Num).HP) * 32))
                            ' draw bars
                            rec(1) = New Rectangle(ConvertMapX(tmpX), ConvertMapY(tmpY), barWidth, 4)
                            Dim rectShape As New RectangleShape(New Vector2f(barWidth, 4)) With {
                                    .Position = New Vector2f(ConvertMapX(tmpX), ConvertMapY(tmpY - 75)),
                                    .FillColor = Color.Red
                                    }
                            GameWindow.Draw(rectShape)

                            If MapNpc(i).Vital(VitalType.MP) > 0 Then
                                ' calculate the width to fill
                                barWidth =
                                    ((MapNpc(i).Vital(VitalType.MP) / (Npc(MapNpc(i).Num).Stat(StatType.Intelligence) * 2) *
                                      32))
                                ' draw bars
                                rec(1) = New Rectangle(ConvertMapX(tmpX), ConvertMapY(tmpY), barWidth, 4)
                                Dim rectShape2 As New RectangleShape(New Vector2f(barWidth, 4)) With {
                                        .Position = New Vector2f(ConvertMapX(tmpX), ConvertMapY(tmpY - 80)),
                                        .FillColor = Color.Blue
                                        }
                                GameWindow.Draw(rectShape2)
                            End If
                        End If
                    End If
                End If
            Next
        End If

        If PetAlive(Myindex) Then
            ' draw own health bar
            If Player(Myindex).Pet.Health > 0 AndAlso Player(Myindex).Pet.Health <= Player(Myindex).Pet.MaxHp Then
                'Debug.Print("pethealth:" & Player(Myindex).Pet.Health)
                ' lock to Player
                tmpX = Player(Myindex).Pet.X * PicX + Player(Myindex).Pet.XOffset
                tmpY = Player(Myindex).Pet.Y * PicX + Player(Myindex).Pet.YOffset + 35
                ' calculate the width to fill
                barWidth = ((Player(Myindex).Pet.Health) / (Player(Myindex).Pet.MaxHp)) * 32
                ' draw bars
                rec(1) = New Rectangle(ConvertMapX(tmpX), ConvertMapY(tmpY), barWidth, 4)
                Dim rectShape As New RectangleShape(New Vector2f(barWidth, 4)) With {
                        .Position = New Vector2f(ConvertMapX(tmpX), ConvertMapY(tmpY - 75)),
                        .FillColor = Color.Red
                        }
                GameWindow.Draw(rectShape)
            End If
        End If

        ' check for pet casting time bar
        If PetSkillBuffer > 0 Then
            If Skill(Pet(Player(Myindex).Pet.Num).Skill(PetSkillBuffer)).CastTime > 0 Then
                ' lock to pet
                tmpX = Player(Myindex).Pet.X * PicX + Player(Myindex).Pet.XOffset
                tmpY = Player(Myindex).Pet.Y * PicY + Player(Myindex).Pet.YOffset + 35

                ' calculate the width to fill
                barWidth = (GetTickCount() - PetSkillBufferTimer) /
                           ((Skill(Pet(Player(Myindex).Pet.Num).Skill(PetSkillBuffer)).CastTime * 1000)) * 64
                ' draw bar background
                rec(1) = New Rectangle(ConvertMapX(tmpX), ConvertMapY(tmpY), barWidth, 4)
                Dim rectShape As New RectangleShape(New Vector2f(barWidth, 4)) With {
                        .Position = New Vector2f(ConvertMapX(tmpX), ConvertMapY(tmpY)),
                        .FillColor = Color.Cyan
                        }
                GameWindow.Draw(rectShape)
            End If
        End If
    End Sub

    Sub DrawMapName()
        DrawText(DrawMapNameX, DrawMapNameY, Language.Game.MapName & Map.Name, DrawMapNameColor, Color.Black, GameWindow)
    End Sub

    Friend Sub DrawGrid()
        For x = TileView.Left To TileView.Right ' - 1
            For y = TileView.Top To TileView.Bottom ' - 1
                If IsValidMapPoint(x, y) Then

                    Dim rec As New RectangleShape With {
                            .OutlineColor = New Color(Color.White),
                            .OutlineThickness = 0.6,
                            .FillColor = New Color(Color.Transparent),
                            .Size = New Vector2f((x * PicX), (y * PicX)),
                            .Position = New Vector2f(ConvertMapX((x - 1) * PicX), ConvertMapY((y - 1) * PicY))
                            }

                    GameWindow.Draw(rec)
                End If
            Next
        Next
    End Sub

    Friend Sub DrawTileOutline()
        Dim rec As Rectangle
        If frmEditor_Map.tabpages.SelectedTab Is frmEditor_Map.tpDirBlock Then Exit Sub

        With rec
            .Y = 0
            .Height = PicY
            .X = 0
            .Width = PicX
        End With

        Dim rec2 As New RectangleShape With {
            .OutlineColor = New SFML.Graphics.Color(SFML.Graphics.Color.Blue),
            .OutlineThickness = 0.6,
            .FillColor = New SFML.Graphics.Color(SFML.Graphics.Color.Transparent)
        }

        If frmEditor_Map.tabpages.SelectedTab Is frmEditor_Map.tpAttributes Then
            rec2.Size = New Vector2f(rec.Width, rec.Height)
        Else
            If TileSetTextureInfo(frmEditor_Map.cmbTileSets.SelectedIndex + 1).IsLoaded = False Then
                LoadTexture(frmEditor_Map.cmbTileSets.SelectedIndex, 1)
            End If
            ' we use it, lets update timer
            With TileSetTextureInfo(frmEditor_Map.cmbTileSets.SelectedIndex + 1)
                .TextureTimer = GetTickCount() + 100000
            End With

            If EditorTileWidth = 1 AndAlso EditorTileHeight = 1 Then
                RenderSprite(TileSetSprite(frmEditor_Map.cmbTileSets.SelectedIndex + 1), GameWindow, ConvertMapX(CurX * PicX), ConvertMapY(CurY * PicY), EditorTileSelStart.X * PicX, EditorTileSelStart.Y * PicY, rec.Width, rec.Height)

                rec2.Size = New Vector2f(rec.Width, rec.Height)
            Else
                If frmEditor_Map.cmbAutoTile.SelectedIndex > 0 Then
                    RenderSprite(TileSetSprite(frmEditor_Map.cmbTileSets.SelectedIndex + 1), GameWindow, ConvertMapX(CurX * PicX), ConvertMapY(CurY * PicY), EditorTileSelStart.X * PicX, EditorTileSelStart.Y * PicY, rec.Width, rec.Height)

                    rec2.Size = New Vector2f(rec.Width, rec.Height)
                Else
                    RenderSprite(TileSetSprite(frmEditor_Map.cmbTileSets.SelectedIndex + 1), GameWindow, ConvertMapX(CurX * PicX), ConvertMapY(CurY * PicY), EditorTileSelStart.X * PicX, EditorTileSelStart.Y * PicY, EditorTileSelEnd.X * PicX, EditorTileSelEnd.Y * PicY)

                    rec2.Size = New Vector2f(EditorTileSelEnd.X * PicX, EditorTileSelEnd.Y * PicY)
                End If

            End If

        End If

        rec2.Position = New Vector2f(ConvertMapX(CurX * PicX), ConvertMapY(CurY * PicY))
        GameWindow.Draw(rec2)
    End Sub

    Friend Sub DrawEyeDropper()
        Dim rec As New RectangleShape With {
        .OutlineColor = New Color(Color.Cyan),
        .OutlineThickness = 0.6,
        .FillColor = New Color(Color.Transparent),
        .Size = New Vector2f((PicX), (PicX)),
        .Position = New Vector2f(ConvertMapX((CurX) * PicX), ConvertMapY((CurY) * PicY))
        }

        GameWindow.Draw(rec)
    End Sub

    Friend Sub DrawMapTint()

        If Map.HasMapTint = 0 Then Exit Sub

        MapTintGfx.Clear(New Color(CurrentTintR, CurrentTintG, CurrentTintB, CurrentTintA))

        'MapTintSprite.Color = New SFML.Graphics.Color(CurrentTintR, CurrentTintG, CurrentTintB, CurrentTintA)
        MapTintSprite = New Sprite(MapTintGfx.Texture) With {
            .TextureRect = New IntRect(0, 0, GameWindow.Size.X, GameWindow.Size.Y),
            .Position = New Vector2f(0, 0)
            }

        MapTintGfx.Display()

        GameWindow.Draw(MapTintSprite)
    End Sub

    Friend Sub DrawMapFade()
        If UseFade = False Then Exit Sub

        MapFadeSprite = New Sprite(New Texture(New Image(GameWindow.Size.X, GameWindow.Size.Y, Color.Black))) With {
            .Color = New Color(0, 0, 0, FadeAmount),
            .TextureRect = New IntRect(0, 0, GameWindow.Size.X, GameWindow.Size.Y),
            .Position = New Vector2f(0, 0)
            }

        GameWindow.Draw(MapFadeSprite)
    End Sub

    Sub DestroyGraphics()
        Try
            For i = 0 To NumAnimations
                If Not AnimationsGfx(i) Is Nothing Then AnimationsGfx(i).Dispose()
            Next i

            For i = 0 To NumCharacters
                If Not CharacterGfx(i) Is Nothing Then CharacterGfx(i).Dispose()
            Next

            For i = 0 To NumItems
                If Not ItemsGfx(i) Is Nothing Then ItemsGfx(i).Dispose()
            Next

            For i = 0 To NumPaperdolls
                If Not PaperDollGfx(i) Is Nothing Then PaperDollGfx(i).Dispose()
            Next

            For i = 0 To NumResources
                If Not ResourcesGfx(i) Is Nothing Then ResourcesGfx(i).Dispose()
            Next

            For i = 0 To NumSkillIcons
                If Not SkillIconsGfx(i) Is Nothing Then SkillIconsGfx(i).Dispose()
            Next

            For i = 0 To NumTileSets
                If Not TileSetTexture(i) Is Nothing Then TileSetTexture(i).Dispose()
            Next i

            For i = 0 To NumFaces
                If Not FacesGfx(i) Is Nothing Then FacesGfx(i).Dispose()
            Next

            For i = 0 To NumFogs
                If Not FogGfx(i) Is Nothing Then FogGfx(i).Dispose()
            Next

            For i = 0 To NumProjectiles
                If Not ProjectileGfx(i) Is Nothing Then ProjectileGfx(i).Dispose()
            Next

            For i = 0 To NumEmotes
                If Not EmotesGfx(i) Is Nothing Then EmotesGfx(i).Dispose()
            Next

            For i = 0 To NumPanorama
                If Not PanoramasGfx(i) Is Nothing Then PanoramasGfx(i).Dispose()
            Next

            For i = 0 To NumParallax
                If Not ParallaxGfx(i) Is Nothing Then ParallaxGfx(i).Dispose()
            Next

            For i = 0 To NumPictures
                If Not PictureGfx(i) Is Nothing Then PictureGfx(i).Dispose()
            Next

            If Not CursorGfx Is Nothing Then CursorGfx.Dispose()
            If Not BloodGfx Is Nothing Then BloodGfx.Dispose()
            If Not DirectionsGfx Is Nothing Then DirectionsGfx.Dispose()
            If Not ActionPanelGfx Is Nothing Then ActionPanelGfx.Dispose()
            If Not InvPanelGfx Is Nothing Then InvPanelGfx.Dispose()
            If Not XpBarPanelGfx Is Nothing Then XpBarPanelGfx.Dispose()
            If Not CharPanelGfx Is Nothing Then CharPanelGfx.Dispose()
            If Not CharPanelPlusGfx Is Nothing Then CharPanelPlusGfx.Dispose()
            If Not CharPanelMinGfx Is Nothing Then CharPanelMinGfx.Dispose()
            If Not TargetGfx Is Nothing Then TargetGfx.Dispose()
            If Not WeatherGfx Is Nothing Then WeatherGfx.Dispose()
            If Not HotBarGfx Is Nothing Then HotBarGfx.Dispose()
            If Not ChatWindowGfx Is Nothing Then ChatWindowGfx.Dispose()
            If Not BankPanelGfx Is Nothing Then BankPanelGfx.Dispose()
            If Not ShopPanelGfx Is Nothing Then ShopPanelGfx.Dispose()
            If Not TradePanelGfx Is Nothing Then TradePanelGfx.Dispose()
            If Not EventChatGfx Is Nothing Then EventChatGfx.Dispose()
            If Not RClickGfx Is Nothing Then RClickGfx.Dispose()
            If Not ButtonGfx Is Nothing Then ButtonGfx.Dispose()
            If Not ButtonHoverGfx Is Nothing Then ButtonHoverGfx.Dispose()
            If Not QuestGfx Is Nothing Then QuestGfx.Dispose()
            If Not CraftGfx Is Nothing Then CraftGfx.Dispose()
            If Not ProgBarGfx Is Nothing Then ProgBarGfx.Dispose()
            If Not ChatBubbleGfx Is Nothing Then ChatBubbleGfx.Dispose()

            If Not HpBarGfx Is Nothing Then HpBarGfx.Dispose()
            If Not MpBarGfx Is Nothing Then MpBarGfx.Dispose()
            If Not ExpBarGfx Is Nothing Then ExpBarGfx.Dispose()

            If Not LightGfx Is Nothing Then LightGfx.Dispose()
            If Not NightGfx Is Nothing Then NightGfx.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Sub DrawHud()
        Dim rec As Rectangle

        'first render backpanel
        With rec
            .Y = 0
            .Height = HudPanelGfxInfo.Height
            .X = 0
            .Width = HudPanelGfxInfo.Width
        End With

        RenderSprite(HudPanelSprite, GameWindow, HudWindowX, HudWindowY, rec.X, rec.Y, rec.Width, rec.Height)

        If Player(Myindex).Sprite <= NumFaces Then
            Dim tmpSprite = New Sprite(FacesGfx(Player(Myindex).Sprite))

            If FacesGfxInfo(Player(Myindex).Sprite).IsLoaded = False Then
                LoadTexture(Player(Myindex).Sprite, 7)
            End If

            'seeying we still use it, lets update timer
            With FacesGfxInfo(Player(Myindex).Sprite)
                .TextureTimer = GetTickCount() + 100000
            End With

            'then render face
            With rec
                .Y = 0
                .Height = FacesGfxInfo(Player(Myindex).Sprite).Height
                .X = 0
                .Width = FacesGfxInfo(Player(Myindex).Sprite).Width
            End With

            RenderSprite(FacesSprite(Player(Myindex).Sprite), GameWindow, HudFaceX, HudFaceY, rec.X, rec.Y, rec.Width,
                         rec.Height)
        End If

        'HP Bar etc
        DrawStatBars()

        DrawText(FrmGame.Width - 120, 10, Language.Game.Fps & Fps, Color.White, Color.Black, GameWindow)
        DrawText(FrmGame.Width - 120, 30, Language.Game.Ping & PingToDraw, Color.White, Color.Black, GameWindow)
        DrawText(FrmGame.Width - 120, 50, Language.Game.Time & Time.Instance.ToString("h:mm"),
                 Color.White, Color.Black, GameWindow)

        If Blps Then
            DrawText(FrmGame.Width - 120, 70, Language.Game.Lps & Lps, Color.White, Color.Black, GameWindow)
        End If

        ' Draw map name
        DrawMapName()
    End Sub

    Sub DrawStatBars()
        Dim rec As Rectangle
        Dim curHp As Integer, curMp As Integer, curExp As Integer

        'HP Bar
        curHp = (GetPlayerVital(Myindex, VitalType.HP) / GetPlayerMaxVital(Myindex, VitalType.HP)) * 100

        With rec
            .Y = 0
            .Height = HpBarGfxInfo.Height
            .X = 0
            .Width = curHp * HpBarGfxInfo.Width / 100
        End With

        'then render full ontop of it
        RenderSprite(HpBarSprite, GameWindow, HudWindowX + HudhpBarX, HudWindowY + HudhpBarY + 4, rec.X, rec.Y,
                     rec.Width, rec.Height)

        'then draw the text onto that
        DrawText(HudWindowX + HudhpBarX + 65, HudWindowY + HudhpBarY + 4,
                 LblHpText, Color.White, Color.Black, GameWindow)

        '==============================

        'MP Bar
        curMp = (GetPlayerVital(Myindex, VitalType.MP) / GetPlayerMaxVital(Myindex, VitalType.MP)) * 100

        'then render full ontop of it
        With rec
            .Y = 0
            .Height = MpBarGfxInfo.Height
            .X = 0
            .Width = curMp * MpBarGfxInfo.Width / 100
        End With

        RenderSprite(MpBarSprite, GameWindow, HudWindowX + HudmpBarX, HudWindowY + HudmpBarY + 4, rec.X, rec.Y,
                     rec.Width, rec.Height)

        'draw text onto that
        DrawText(HudWindowX + HudmpBarX + 45, HudWindowY + HudmpBarY + 4,
                 LblManaText, Color.White, Color.Black, GameWindow)

        '====================================================
        'EXP Bar
        curExp = (GetPlayerExp(Myindex) / NextlevelExp) * 100

        'then render full ontop of it
        With rec
            .Y = 0
            .Height = ExpBarGfxInfo.Height
            .X = 0
            .Width = curExp * ExpBarGfxInfo.Width / 100
        End With

        If GameWindow.Size.X >= 1336 Then
            RenderSprite(XpBarPanelSprite, GameWindow, GameWindow.Size.X / 2 - XpBarPanelGfxInfo.Width / 2, GameWindow.Size.Y - XpBarPanelGfxInfo.Height, 0, 0, XpBarPanelGfxInfo.Width,
                         XpBarPanelGfxInfo.Height)

            RenderSprite(ExpBarSprite, GameWindow, GameWindow.Size.X / 2 - ExpBarGfxInfo.Width / 2, GameWindow.Size.Y - ExpBarGfxInfo.Height - 7, rec.X, rec.Y,
                         rec.Width, rec.Height)
        Else
            RenderSprite(XpBarPanelSprite, GameWindow, GameWindow.Size.X - XpBarPanelGfxInfo.Width, 0, 0, 0, XpBarPanelGfxInfo.Width,
                         XpBarPanelGfxInfo.Height)

            RenderSprite(ExpBarSprite, GameWindow, GameWindow.Size.X - ExpBarGfxInfo.Width - 12, 0 + ExpBarGfxInfo.Height, rec.X, rec.Y,
                         rec.Width, rec.Height)
        End If
    End Sub

    Sub DrawActionPanel()
        Dim rec As Rectangle

        'first render backpanel
        With rec
            .Y = 0
            .Height = ActionPanelGfxInfo.Height
            .X = 0
            .Width = ActionPanelGfxInfo.Width
        End With

        RenderSprite(ActionPanelSprite, GameWindow, ActionPanelX + 20, ActionPanelY, rec.X, rec.Y, rec.Width, rec.Height)
    End Sub

    Friend Sub DrawInventoryItem(x As Integer, y As Integer)
        Dim rec As Rectangle
        Dim itemnum As Integer, itempic As Integer

        itemnum = GetPlayerInvItemNum(Myindex, DragInvSlotNum)

        If itemnum > 0 AndAlso itemnum <= MAX_ITEMS Then

            itempic = Item(itemnum).Pic
            If itempic = 0 Then Exit Sub

            If ItemsGfxInfo(itempic).IsLoaded = False Then
                LoadTexture(itempic, 4)
            End If

            'seeying we still use it, lets update timer
            With ItemsGfxInfo(itempic)
                .TextureTimer = GetTickCount() + 100000
            End With

            With rec
                .Y = 0
                .Height = PicY
                .X = 0
                .Width = PicX
            End With

            RenderSprite(ItemsSprite(itempic), GameWindow, x + 16, y + 16, rec.X, rec.Y, rec.Width, rec.Height)
        End If
    End Sub

    Sub DrawInventory()
        Dim i As Integer, x As Integer, y As Integer, itemnum As Integer, itempic As Integer
        Dim amount As String
        Dim rec As Rectangle, recPos As Rectangle
        Dim colour As Color

        'first render panel
        RenderSprite(InvPanelSprite, GameWindow, InvWindowX, InvWindowY, 0, 0, InvPanelGfxInfo.Width,
                     InvPanelGfxInfo.Height)

        For i = 1 To MAX_INV
            itemnum = GetPlayerInvItemNum(Myindex, i)

            If itemnum > 0 AndAlso itemnum <= MAX_ITEMS Then
                StreamItem(itemnum)
                itempic = Item(itemnum).Pic
                If itempic = 0 Then GoTo NextLoop

                If ItemsGfxInfo(itempic).IsLoaded = False Then
                    LoadTexture(itempic, 4)
                End If

                'seeying we still use it, lets update timer
                With ItemsGfxInfo(itempic)
                    .TextureTimer = GetTickCount() + 100000
                End With

                ' exit out if we're offering item in a trade.
                If InTrade > 0 Then
                    For x = 1 To MAX_INV
                        If TradeYourOffer(x).Num = i Then
                            GoTo NextLoop
                        End If
                    Next
                End If

                If itempic > 0 AndAlso itempic <= NumItems Then
                    If ItemsGfxInfo(itempic).Width <= 64 Then ' more than 1 frame is handled by anim sub

                        With rec
                            .Y = 0
                            .Height = 32
                            .X = 0
                            .Width = 32
                        End With

                        With recPos
                            .Y = InvWindowY + InvTop + ((InvOffsetY + 32) * ((i - 1) \ InvColumns))
                            .Height = PicY
                            .X = InvWindowX + InvLeft + ((InvOffsetX + 32) * (((i - 1) Mod InvColumns)))
                            .Width = PicX
                        End With

                        RenderSprite(ItemsSprite(itempic), GameWindow, recPos.X, recPos.Y, rec.X, rec.Y, rec.Width,
                                     rec.Height)

                        ' If item is a stack - draw the amount you have
                        If GetPlayerInvItemValue(Myindex, i) > 1 Then
                            y = recPos.Top + 22
                            x = recPos.Left - 4
                            amount = GetPlayerInvItemValue(Myindex, i)

                            colour = Color.White

                            ' Draw currency but with k, m, b etc. using a convertion function
                            If CLng(amount) < 1000000 Then
                                colour = Color.White
                            ElseIf CLng(amount) > 1000000 AndAlso CLng(amount) < 10000000 Then
                                colour = Color.Yellow
                            ElseIf CLng(amount) > 10000000 Then
                                colour = Color.Green
                            End If

                            DrawText(x, y, ConvertCurrency(amount), colour, Color.Black, GameWindow)

                        End If
                    End If
                End If
            End If
NextLoop:
        Next

        DrawAnimatedInvItems()
    End Sub

    Sub DrawAnimatedInvItems()
        Dim i As Integer
        Dim itemnum As Integer, itempic As Integer
        Dim x As Integer, y As Integer
        Dim maxFrames As Byte
        Dim amount As Integer
        Dim rec As Rectangle, recPos As Rectangle
        Dim clearregion(1) As Rectangle
        Static tmr100 As Integer
        If tmr100 = 0 Then tmr100 = GetTickCount() + 100

        If GetTickCount() > tmr100 Then
            ' check for map animation changes#
            For i = 1 To MAX_MAP_ITEMS

                If MapItem(i).Num > 0 Then
                    itempic = Item(MapItem(i).Num).Pic

                    If itempic < 1 OrElse itempic > NumItems Then Exit Sub
                    maxFrames = (ItemsGfxInfo(itempic).Width / 2) / 32 _
                    ' Work out how many frames there are. /2 because of inventory icons as well as ingame

                    If MapItem(i).Frame < maxFrames - 1 Then
                        MapItem(i).Frame = MapItem(i).Frame + 1
                    Else
                        MapItem(i).Frame = 1
                    End If
                End If
            Next
        End If

        For i = 1 To MAX_INV
            itemnum = GetPlayerInvItemNum(Myindex, i)

            If itemnum > 0 AndAlso itemnum <= MAX_ITEMS Then
                itempic = Item(itemnum).Pic
                If itempic > 0 AndAlso itempic <= NumItems Then
                    If ItemsGfxInfo(itempic).Width > 64 Then

                        maxFrames = (ItemsGfxInfo(itempic).Width / 2) / 32 _
                        ' Work out how many frames there are. /2 because of inventory icons as well as ingame

                        If GetTickCount() > tmr100 Then
                            If InvItemFrame(i) < maxFrames - 1 Then
                                InvItemFrame(i) = InvItemFrame(i) + 1
                            Else
                                InvItemFrame(i) = 1
                            End If
                            tmr100 = GetTickCount() + 100
                        End If

                        With rec
                            .Y = 0
                            .Height = 32
                            .X = (ItemsGfxInfo(itempic).Width / 2) + (InvItemFrame(i) * 32) _
                            ' middle to get the start of inv gfx, then +32 for each frame
                            .Width = 32
                        End With

                        With recPos
                            .Y = InvTop + ((InvOffsetY + 32) * ((i - 1) \ InvColumns))
                            .Height = PicY
                            .X = InvLeft + ((InvOffsetX + 32) * (((i - 1) Mod InvColumns)))
                            .Width = PicX
                        End With
                        With clearregion(1)
                            .Y = recPos.Y
                            .Height = recPos.Height
                            .X = recPos.X
                            .Width = recPos.Width
                        End With

                        ' We'll now re-draw the item, and place the currency value over it again :P
                        RenderSprite(ItemsSprite(itempic), GameWindow, recPos.X, recPos.Y, rec.X, rec.Y, rec.Width,
                                     rec.Height)

                        ' If item is a stack - draw the amount you have
                        If GetPlayerInvItemValue(Myindex, i) > 1 Then
                            y = recPos.Top + 22
                            x = recPos.Left - 4
                            amount = CStr(GetPlayerInvItemValue(Myindex, i))
                            ' Draw currency but with k, m, b etc. using a convertion function
                            DrawText(x, y, ConvertCurrency(amount), Color.Yellow, Color.Black, GameWindow)

                        End If
                    End If
                End If
            End If

        Next
    End Sub

    Friend Sub DrawSkillItem(x As Integer, y As Integer)
        Dim rec As Rectangle
        Dim skillnum As Integer, skillpic As Integer

        skillnum = DragSkillSlotNum

        If skillnum > 0 AndAlso skillnum <= MAX_SKILLS Then
            StreamSkill(skillnum)
            skillpic = Skill(skillnum).Icon
            If skillpic = 0 Then Exit Sub

            If SkillIconsGfxInfo(skillpic).IsLoaded = False Then
                LoadTexture(skillpic, 9)
            End If

            'seeying we still use it, lets update timer
            With SkillIconsGfxInfo(skillnum)
                .TextureTimer = GetTickCount() + 100000
            End With

            With rec
                .Y = 0
                .Height = PicY
                .X = 0
                .Width = PicX
            End With

            RenderSprite(SkillIconsSprite(skillpic), GameWindow, x + 16, y + 16, rec.X, rec.Y, rec.Width, rec.Height)
        End If
    End Sub

    Sub DrawPlayerSkills()
        Dim i As Integer, skillnum As Integer, skillicon As Integer
        Dim rec As Rectangle, recPos As Rectangle

        If Not InGame Then Exit Sub

        'first render panel
        RenderSprite(SkillPanelSprite, GameWindow, SkillWindowX, SkillWindowY, 0, 0, SkillPanelGfxInfo.Width,
                     SkillPanelGfxInfo.Height)

        For i = 1 To MAX_PLAYER_SKILLS
            skillnum = Player(Myindex).Skill(i).Num

            If skillnum > 0 AndAlso skillnum <= MAX_SKILLS Then
                StreamSkill(skillnum)
                skillicon = Skill(skillnum).Icon

                If skillicon > 0 AndAlso skillicon <= NumSkillIcons Then

                    If SkillIconsGfxInfo(skillicon).IsLoaded = False Then
                        LoadTexture(skillicon, 9)
                    End If

                    'seeying we still use it, lets update timer
                    With SkillIconsGfxInfo(skillicon)
                        .TextureTimer = GetTickCount() + 100000
                    End With

                    With rec
                        .Y = 0
                        .Height = 32
                        .X = 0
                        .Width = 32
                    End With

                    If Not Player(Myindex).Skill(i).CD = 0 Then
                        rec.X = 32
                        rec.Width = 32
                    End If

                    With recPos
                        .Y = SkillWindowY + SkillTop + ((SkillOffsetY + 32) * ((i - 1) \ SkillColumns))
                        .Height = PicY
                        .X = SkillWindowX + SkillLeft + ((SkillOffsetX + 32) * (((i - 1) Mod SkillColumns)))
                        .Width = PicX
                    End With

                    RenderSprite(SkillIconsSprite(skillicon), GameWindow, recPos.X, recPos.Y, rec.X, rec.Y, rec.Width,
                                 rec.Height)
                End If
            End If
        Next
    End Sub

    Friend Function ToSfmlColor(toConvert As Drawing.Color) As Color
        Return New Color(toConvert.R, toConvert.G, toConvert.G, toConvert.A)
    End Function

    Friend Sub DrawTarget(x2 As Integer, y2 As Integer)
        Dim rec As Rectangle
        Dim x As Integer, y As Integer
        Dim width As Integer, height As Integer

        With rec
            .Y = 0
            .Height = TargetGfxInfo.Height
            .X = 0
            .Width = TargetGfxInfo.Width / 2
        End With

        x = ConvertMapX(x2)
        y = ConvertMapY(y2)
        width = (rec.Right - rec.Left)
        height = (rec.Bottom - rec.Top)

        RenderSprite(TargetSprite, GameWindow, x, y, rec.X, rec.Y, rec.Width, rec.Height)
    End Sub

    Friend Sub DrawHover(x2 As Integer, y2 As Integer)
        Dim rec As Rectangle
        Dim x As Integer, y As Integer
        Dim width As Integer, height As Integer
        With rec
            .Y = 0
            .Height = TargetGfxInfo.Height
            .X = TargetGfxInfo.Width / 2
            .Width = TargetGfxInfo.Width / 2 + TargetGfxInfo.Width / 2
        End With

        x = ConvertMapX(x2)
        y = ConvertMapY(y2)
        width = (rec.Right - rec.Left)
        height = (rec.Bottom - rec.Top)

        RenderSprite(TargetSprite, GameWindow, x, y, rec.X, rec.Y, rec.Width, rec.Height)
    End Sub

    Friend Sub DrawItemDesc()
        Dim xoffset As Integer, yoffset As Integer, y As Integer

        y = 0

        If PnlCharacterVisible = True Then
            xoffset = CharWindowX
            yoffset = CharWindowY
        End If
        If PnlInventoryVisible = True Then
            xoffset = InvWindowX
            yoffset = InvWindowY
        End If
        If PnlBankVisible = True Then
            xoffset = BankWindowX
            yoffset = BankWindowY
        End If
        If PnlShopVisible = True Then
            xoffset = ShopWindowX
            yoffset = ShopWindowY
        End If
        If PnlTradeVisible = True Then
            xoffset = TradeWindowX
            yoffset = TradeWindowY
        End If

        'first render panel
        RenderSprite(DescriptionSprite, GameWindow, xoffset - DescriptionGfxInfo.Width, yoffset, 0, 0,
                     DescriptionGfxInfo.Width, DescriptionGfxInfo.Height)

        'name
        For Each str As String In WordWrap(ItemDescName, 22, WrapMode.Characters, WrapType.BreakWord)
            'description
            DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 12 + y, str, ItemDescRarityColor,
                     ItemDescRarityBackColor, GameWindow)
            y += 15
        Next

        If VbKeyShift Then
            'info
            DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 56, ItemDescInfo, Color.White, Color.Black,
                     GameWindow)

            'cost
            'DrawText(Xoffset - DescriptionGFXInfo.width + 10, Yoffset + 74, "Worth: " & ItemDescCost, SFML.Graphics.Color.White, SFML.Graphics.Color.Black, GameWindow)
            'type
            'DrawText(Xoffset - DescriptionGFXInfo.width + 10, Yoffset + 90, "Type: " & ItemDescType, SFML.Graphics.Color.White, SFML.Graphics.Color.Black, GameWindow)
            'speed
            DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 74, "Speed: " & ItemDescSpeed, Color.White,
                     Color.Black, GameWindow)
            'level
            DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 90, "Level Required: " & ItemDescLevel,
                     Color.White, Color.Black, GameWindow)
            'bonuses
            DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 118, "Bonuses", Color.White, Color.Black,
                     GameWindow)
            'strength
            DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 134, "Strenght: " & ItemDescStr, Color.White,
                     Color.Black, GameWindow)
            'vitality
            DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 150, "Vitality: " & ItemDescVit, Color.White,
                     Color.Black, GameWindow)
            'intelligence
            DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 166, "Intelligence: " & ItemDescInt, Color.White,
                     Color.Black, GameWindow)
            'endurance
            DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 182, "Endurance: " & ItemDescEnd, Color.White,
                     Color.Black, GameWindow)
            'luck
            DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 198, "Luck: " & ItemDescLuck, Color.White,
                     Color.Black, GameWindow)
            'spirit
            DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 214, "Spirit: " & ItemDescSpr, Color.White,
                     Color.Black, GameWindow)
        Else
            For Each str As String In WordWrap(ItemDescDescription, 22, WrapMode.Characters, WrapType.BreakWord)
                'description
                DrawText(xoffset - DescriptionGfxInfo.Width + 10, yoffset + 44 + y, str, Color.White, Color.Black,
                         GameWindow)
                y += 15
            Next
        End If
    End Sub

    Friend Sub DrawSkillDesc()
        'first render panel
        RenderSprite(DescriptionSprite, GameWindow, SkillWindowX - DescriptionGfxInfo.Width, SkillWindowY, 0, 0,
                     DescriptionGfxInfo.Width, DescriptionGfxInfo.Height)

        'name
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 12, SkillDescName, Color.White,
                 Color.Black, GameWindow)
        'type
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 28, SkillDescInfo, Color.White,
                 Color.Black, GameWindow)
        'cast time
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 44, "Cast Time: " & SkillDescCastTime,
                 Color.White, Color.Black, GameWindow)
        'cool down
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 58, "CoolDown: " & SkillDescCoolDown,
                 Color.White, Color.Black, GameWindow)
        'Damage
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 74, "Damage: " & SkillDescDamage,
                 Color.White, Color.Black, GameWindow)
        'AOE
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 90, "Aoe: " & SkillDescAoe, Color.White,
                 Color.Black, GameWindow)
        'range
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 104, "Range: " & SkillDescRange,
                 Color.White, Color.Black, GameWindow)

        'requirements
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 128, "=Requirements=", Color.White,
                 Color.Black, GameWindow)
        'MP
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 144, "MP: " & SkillDescReqMp, Color.White,
                 Color.Black, GameWindow)
        'level
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 160, "Level: " & SkillDescReqLvl,
                 Color.White, Color.Black, GameWindow)
        'Access
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 176, "Access: " & SkillDescReqAccess,
                 Color.White, Color.Black, GameWindow)
        'Class
        DrawText(SkillWindowX - DescriptionGfxInfo.Width + 10, SkillWindowY + 192, "Job: " & SkillDescReqClass,
                 Color.White, Color.Black, GameWindow)
    End Sub

    Friend Sub DrawDialogPanel()
        'first render panel
        RenderSprite(EventChatSprite, GameWindow, DialogPanelX, DialogPanelY, 0, 0, EventChatGfxInfo.Width,
                     EventChatGfxInfo.Height)

        DrawText(DialogPanelX + 175, DialogPanelY + 10, Trim(DialogMsg1), Color.White, Color.Black, GameWindow)

        If Len(DialogMsg2) > 0 Then
            DrawText(DialogPanelX + 60, DialogPanelY + 30, Trim(DialogMsg2), Color.White, Color.Black, GameWindow)
        End If

        If Len(DialogMsg3) > 0 Then
            DrawText(DialogPanelX + 60, DialogPanelY + 50, Trim(DialogMsg3), Color.White, Color.Black, GameWindow)
        End If

        'render ok button
        DrawButton(DialogButton1Text, DialogPanelX + OkButtonX, DialogPanelY + OkButtonY, 0)

        'render cancel button
        DrawButton(DialogButton2Text, DialogPanelX + CancelButtonX, DialogPanelY + CancelButtonY, 0)
    End Sub

    Friend Sub DrawRClick()
        'first render panel
        RenderSprite(RClickSprite, GameWindow, RClickX, RClickY, 0, 0, RClickGfxInfo.Width, RClickGfxInfo.Height)

        DrawText(RClickX + (RClickGfxInfo.Width \ 2) - (GetTextWidth(RClickname) \ 2), RClickY + 10, RClickname, Color.White,
                 Color.Black, GameWindow)

        DrawText(RClickX + (RClickGfxInfo.Width \ 2) - (GetTextWidth("Invite to Trade") \ 2), RClickY + 35,
                 "Invite to Trade", Color.White, Color.Black, GameWindow)

        DrawText(RClickX + (RClickGfxInfo.Width \ 2) - (GetTextWidth("Invite to Party") \ 2), RClickY + 60,
                 "Invite to Party", Color.White, Color.Black, GameWindow)

    End Sub

    Friend Sub DrawGui()
        'hide GUI when mapping...
        If HideGui = True Then Exit Sub

        If HudVisible = True Then
            DrawHud()
            DrawActionPanel()
            DrawChat()
            DrawHotbar()
            DrawPetBar()
            DrawPetStats()
        End If

        If PnlCharacterVisible = True Then
            DrawEquipment()
            If ShowItemDesc = True Then DrawItemDesc()
        End If

        If PnlInventoryVisible = True Then
            DrawInventory()
            If ShowItemDesc = True Then DrawItemDesc()
        End If

        If PnlSkillsVisible = True Then
            DrawPlayerSkills()
            If ShowSkillDesc = True Then DrawSkillDesc()
        End If

        If DialogPanelVisible = True Then
            DrawDialogPanel()
        End If

        If PnlBankVisible = True Then
            DrawBank()
        End If

        If PnlShopVisible = True Then
            DrawShop()
        End If

        If PnlTradeVisible = True Then
            DrawTrade()
        End If

        If PnlEventChatVisible = True Then
            DrawEventChat()
        End If

        If PnlRClickVisible = True Then
            DrawRClick()
        End If

        If DragInvSlotNum > 0 Then
            DrawInventoryItem(CurMouseX, CurMouseY)
        End If

        If DragBankSlotNum > 0 Then
            DrawBankItem(CurMouseX, CurMouseY)
        End If

        If DragSkillSlotNum > 0 Then
            DrawSkillItem(CurMouseX, CurMouseY)
        End If

        'draw cursor
        'DrawCursor()
    End Sub

    Friend Sub EditorItem_DrawItem()
        Dim itemnum As Integer
        itemnum = frmEditor_Item.nudPic.Value

        If itemnum < 1 OrElse itemnum > NumItems Then
            frmEditor_Item.picItem.BackgroundImage = Nothing
            Exit Sub
        End If

        If File.Exists(Paths.Graphics & "items\" & itemnum & GfxExt) Then
            frmEditor_Item.picItem.BackgroundImage = Drawing.Image.FromFile(Paths.Graphics & "items\" & itemnum & GfxExt)
        Else
            frmEditor_Item.picItem.BackgroundImage = Nothing
        End If
    End Sub

    Friend Sub EditorItem_DrawPaperdoll()
        Dim Sprite As Integer

        Sprite = frmEditor_Item.nudPaperdoll.Value

        If Sprite < 1 OrElse Sprite > NumPaperdolls Then
            frmEditor_Item.picPaperdoll.BackgroundImage = Nothing
            Exit Sub
        End If

        If File.Exists(Paths.Graphics & "paperdolls\" & Sprite & GfxExt) Then
            frmEditor_Item.picPaperdoll.BackgroundImage =
                Drawing.Image.FromFile(Paths.Graphics & "paperdolls\" & Sprite & GfxExt)
        End If
    End Sub

    Friend Sub EditorNpc_DrawSprite()
        Dim Sprite As Integer

        Sprite = frmEditor_NPC.nudSprite.Value

        If Sprite < 1 OrElse Sprite > NumCharacters Then
            frmEditor_NPC.picSprite.BackgroundImage = Nothing
            Exit Sub
        End If

        If File.Exists(Paths.Graphics & "characters\" & Sprite & GfxExt) Then
            frmEditor_NPC.picSprite.Width =
                Drawing.Image.FromFile(Paths.Graphics & "characters\" & Sprite & GfxExt).Width / 4
            frmEditor_NPC.picSprite.Height =
                Drawing.Image.FromFile(Paths.Graphics & "characters\" & Sprite & GfxExt).Height / 4
            frmEditor_NPC.picSprite.BackgroundImage =
                Drawing.Image.FromFile(Paths.Graphics & "characters\" & Sprite & GfxExt)
        End If
    End Sub

    Friend Sub EditorResource_DrawSprite()
        Dim Sprite As Integer

        ' normal sprite
        Sprite = frmEditor_Resource.nudNormalPic.Value

        If Sprite < 1 OrElse Sprite > NumResources Then
            frmEditor_Resource.picNormalpic.BackgroundImage = Nothing
        Else
            If File.Exists(Paths.Graphics & "resources\" & Sprite & GfxExt) Then
                frmEditor_Resource.picNormalpic.BackgroundImage =
                    Drawing.Image.FromFile(Paths.Graphics & "resources\" & Sprite & GfxExt)
            End If
        End If

        ' exhausted sprite
        Sprite = frmEditor_Resource.nudExhaustedPic.Value

        If Sprite < 1 OrElse Sprite > NumResources Then
            frmEditor_Resource.picExhaustedPic.BackgroundImage = Nothing
        Else
            If File.Exists(Paths.Graphics & "resources\" & Sprite & GfxExt) Then
                frmEditor_Resource.picExhaustedPic.BackgroundImage =
                    Drawing.Image.FromFile(Paths.Graphics & "resources\" & Sprite & GfxExt)
            End If
        End If
    End Sub

    Friend Sub EditorEvent_DrawPicture()
        Dim Sprite As Integer

        Sprite = FrmEditor_Events.nudShowPicture.Value

        If Sprite < 1 OrElse Sprite > NumPictures Then
            FrmEditor_Events.picShowPic.BackgroundImage = Nothing
            Exit Sub
        End If

        If File.Exists(Paths.Graphics & "pictures\" & Sprite & GfxExt) Then
            FrmEditor_Events.picShowPic.Width =
                Drawing.Image.FromFile(Paths.Graphics & "pictures\" & Sprite & GfxExt).Width
            FrmEditor_Events.picShowPic.Height =
                Drawing.Image.FromFile(Paths.Graphics & "pictures\" & Sprite & GfxExt).Height
            FrmEditor_Events.picShowPic.BackgroundImage =
                Drawing.Image.FromFile(Paths.Graphics & "pictures\" & Sprite & GfxExt)
        End If
    End Sub

    Public Sub DrawNight()
        Dim x = 0
        Dim y = 0

        If InGame = False Then Exit Sub
        If NightGfx Is Nothing Then Exit Sub
        If GettingMap Then Exit Sub
        If Editor = EditorType.Map And Night = False Then Exit Sub

        If Map.Moral = CByte(MapMoralType.Indoors) Then
            NightGfx.Clear(New Color(CByte(0), CByte(0), CByte(0), CByte(Map.Brightness)))
            Exit Sub
        End If

        If Map.Brightness > 0 Then
            NightGfx.Clear(New Color(CByte(0), CByte(0), CByte(0), CByte(Map.Brightness)))
        ElseIf Time.Instance.TimeOfDay = TimeOfDay.Dawn Then
            NightGfx.Clear(New Color(CByte(0), CByte(0), CByte(0), CByte(100)))
        ElseIf Time.Instance.TimeOfDay = TimeOfDay.Dusk Then
            NightGfx.Clear(New Color(CByte(0), CByte(0), CByte(0), CByte(150)))
        ElseIf Time.Instance.TimeOfDay = TimeOfDay.Night Then
            NightGfx.Clear(New Color(CByte(0), CByte(0), CByte(0), CByte(200)))
        Else
            Return
        End If

        If tempTileLights Is Nothing Then
            tempTileLights = New List(Of LightTileStruct)()

            For x = 0 To Map.MaxX

                For y = 0 To Map.MaxY

                    If IsValidMapPoint(x, y) Then

                        If Map.Tile(x, y).Type = CByte(TileType.Light) Then

                            If Map.Tile(x, y).Data3 = 1 Then
                                Dim tiles As List(Of Vector2i) = AppendFov(x, y, Map.Tile(x, y).Data1, True)
                                tiles.Add(New Vector2i(x, y))
                                Dim scale = New Vector2f()

                                If Map.Tile(x, y).Data2 = 1 Then
                                    Dim r = CSng(RandomNumberBetween(-0.01F, 0.01F))
                                    scale = New Vector2f(0.35F + r, 0.35F + r)
                                Else
                                    scale = New Vector2f(0.35F, 0.35F)
                                End If

                                If Settings.DynamicLightRendering Then

                                    For Each tile As Vector2i In tiles
                                        LightSprite.Scale = scale
                                        LightSprite.Position =
                                            New Vector2f(
                                                (ConvertMapX(tile.X * 32) - (LightGfx.Size.X / 2 * LightSprite.Scale.X) + 16),
                                                (ConvertMapY(tile.Y * 32) - (LightGfx.Size.Y / 2 * LightSprite.Scale.Y) + 16))
                                        Dim dist = CByte(((Math.Abs(x - tile.X) + Math.Abs(y - tile.Y))))
                                        LightSprite.Color = New Color(0, 0, 0, 255)
                                        NightGfx.Draw(LightSprite, New RenderStates(BlendMode.Multiply))
                                    Next

                                    tempTileLights.Add(New LightTileStruct() With {
                                                          .tiles = tiles,
                                                          .isFlicker = Map.Tile(x, y).Data2 = 1,
                                                          .scale = New Vector2f(0.35F, 0.35F)
                                                          })
                                Else
                                    Dim alphaBump As Byte

                                    If Map.Tile(x, y).Data1 = 0 Then
                                        alphaBump = 255
                                    Else
                                        alphaBump = CByte((255 / (Map.Tile(x, y).Data1)))
                                    End If

                                    For Each tile As Vector2i In tiles
                                        LightDynamicSprite.Scale = scale
                                        LightDynamicSprite.Position = New Vector2f((ConvertMapX(tile.X * 32)),
                                                                                   (ConvertMapY(tile.Y * 32)))
                                        Dim dist = CByte(((Math.Abs(x - tile.X) + Math.Abs(y - tile.Y))))
                                        LightDynamicSprite.Color = New Color(0, 0, 0,
                                                                             CByte(Clamp((alphaBump * dist), 0, 255)))
                                        NightGfx.Draw(LightDynamicSprite, New RenderStates(BlendMode.Multiply))
                                    Next

                                    tempTileLights.Add(New LightTileStruct() With {
                                                          .tiles = tiles,
                                                          .isFlicker = Map.Tile(x, y).Data2 = 1,
                                                          .scale = New Vector2f(0.35F, 0.35F)
                                                          })
                                End If
                            Else
                                LightSprite.Color = Color.Red
                                Dim scale = New Vector2f()

                                If Map.Tile(x, y).Data2 = 1 Then
                                    Dim r = CSng(RandomNumberBetween(-0.01F, 0.01F))
                                    scale = New Vector2f(0.3F * Map.Tile(x, y).Data1 + r, 0.3F * Map.Tile(x, y).Data1 + r)
                                Else
                                    scale = New Vector2f(0.3F * Map.Tile(x, y).Data1, 0.3F * Map.Tile(x, y).Data1)
                                End If

                                LightSprite.Scale = scale
                                Dim x1 = (ConvertMapX(x * 32) + 16 - CDbl((LightGfxInfo.Width * scale.X)) / 2)
                                Dim y1 = (ConvertMapY(y * 32) + 16 - CDbl((LightGfxInfo.Height * scale.Y)) / 2)
                                LightSprite.Position = New Vector2f(CSng(x1), CSng(y1))
                                tempTileLights.Add(New LightTileStruct() With {
                                                      .tiles = New List(Of Vector2i)() From {
                                                      New Vector2i(x, y)
                                                      },
                                                      .isFlicker = Map.Tile(x, y).Data2 = 1,
                                                      .scale =
                                                      New Vector2f(0.3F * Map.Tile(x, y).Data1, 0.3F * Map.Tile(x, y).Data1)
                                                      })
                                NightGfx.Draw(LightSprite, New RenderStates(BlendMode.Multiply))
                            End If
                        End If
                    End If
                Next
            Next
        Else

            For Each light As LightTileStruct In tempTileLights
                Dim scale = New Vector2f()

                If light.isFlicker Then
                    Dim r = CSng(RandomNumberBetween(-0.004F, 0.004F))
                    scale = New Vector2f(light.scale.X + r, light.scale.Y + r)
                Else
                    scale = light.scale
                End If

                For Each tile As Vector2i In light.tiles

                    If light.isSmooth = False Then
                        LightSprite.Scale = scale
                        LightSprite.Position =
                            New Vector2f((ConvertMapX(tile.X * 32) - (LightGfx.Size.X / 2 * LightSprite.Scale.X) + 16),
                                         (ConvertMapY(tile.Y * 32) - (LightGfx.Size.Y / 2 * LightSprite.Scale.Y) + 16))
                        Dim dist = CByte(((Math.Abs(x - tile.X) + Math.Abs(y - tile.Y))))
                        LightSprite.Color = New Color(0, 0, 0, 255)
                        NightGfx.Draw(LightSprite, New RenderStates(BlendMode.Multiply))
                    Else
                        Dim alphaBump As Byte

                        If Map.Tile(x, y).Data1 = 0 Then
                            alphaBump = 255
                        Else
                            alphaBump = CByte((255 / (Map.Tile(x, y).Data1)))
                        End If

                        LightDynamicSprite = New Sprite
                        LightDynamicSprite.Scale = scale
                        LightDynamicSprite.Position = New Vector2f((ConvertMapX(tile.X * 32)), (ConvertMapY(tile.Y * 32)))
                        Dim dist = CByte(((Math.Abs(x - tile.X) + Math.Abs(y - tile.Y))))
                        LightDynamicSprite.Color = New Color(0, 0, 0, CByte(Clamp((alphaBump * dist), 0, 255)))
                        NightGfx.Draw(LightDynamicSprite, New RenderStates(BlendMode.Multiply))
                    End If
                Next
            Next
        End If

        Dim x2 = ConvertMapX(Player(Myindex).X * 32) + 56 + Player(Myindex).XOffset - CDbl(LightGfxInfo.Width) / 2
        Dim y2 = ConvertMapY(Player(Myindex).Y * 32) + 56 + Player(Myindex).YOffset - CDbl(LightGfxInfo.Height) / 2
        LightSprite.Position = New Vector2f(CSng(x2), CSng(y2))
        LightSprite.Color = Color.Red
        LightSprite.Scale = New Vector2f(0.7F, 0.7F)
        NightGfx.Draw(LightSprite, New RenderStates(BlendMode.Multiply))
        NightSprite = New Sprite(NightGfx.Texture)
        NightGfx.Display()
        GameWindow.Draw(NightSprite)
    End Sub

    Friend Sub EditorSkill_DrawIcon()
        Dim iconnum As Integer
        Dim sRECT As Rectangle
        Dim dRECT As Rectangle
        iconnum = frmEditor_Skill.nudIcon.Value

        If iconnum < 1 OrElse iconnum > NumSkillIcons Then
            EditorSkill_Icon.Clear(ToSfmlColor(frmEditor_Skill.picSprite.BackColor))
            EditorSkill_Icon.Display()
            Exit Sub
        End If

        If SkillIconsGfxInfo(iconnum).IsLoaded = False Then
            LoadTexture(iconnum, 9)
        End If

        'seeying we still use it, lets update timer
        With SkillIconsGfxInfo(iconnum)
            .TextureTimer = GetTickCount() + 100000
        End With

        With sRECT
            .Y = 0
            .Height = PicY
            .X = 0
            .Width = PicX
        End With

        'drect is the same, so just copy it
        dRECT = sRECT

        EditorSkill_Icon.Clear(ToSfmlColor(frmEditor_Skill.picSprite.BackColor))

        RenderSprite(SkillIconsSprite(iconnum), EditorSkill_Icon, dRECT.X, dRECT.Y, sRECT.X, sRECT.Y, sRECT.Width,
                     sRECT.Height)

        EditorSkill_Icon.Display()
    End Sub

    Friend Sub EditorAnim_DrawAnim()
        Dim Animationnum As Integer
        Dim sRECT As Rectangle
        Dim dRECT As Rectangle
        Dim width As Integer, height As Integer
        Dim looptime As Integer
        Dim FrameCount As Integer
        Dim ShouldRender As Boolean

        Animationnum = FrmEditor_Animation.nudSprite0.Value

        If Animationnum < 1 OrElse Animationnum > NumAnimations Then
            EditorAnimation_Anim1.Clear(ToSfmlColor(FrmEditor_Animation.picSprite0.BackColor))
            EditorAnimation_Anim1.Display()
        Else
            If AnimationsGfxInfo(Animationnum).IsLoaded = False Then
                LoadTexture(Animationnum, 6)
            End If

            'seeying we still use it, lets update timer
            With AnimationsGfxInfo(Animationnum)
                .TextureTimer = GetTickCount() + 100000
            End With

            looptime = FrmEditor_Animation.nudLoopTime0.Value
            FrameCount = FrmEditor_Animation.nudFrameCount0.Value

            ShouldRender = False

            ' check if we need to render new frame
            If AnimEditorTimer(0) + looptime <= GetTickCount() Then
                ' check if out of range
                If AnimEditorFrame(0) >= FrameCount Then
                    AnimEditorFrame(0) = 1
                Else
                    AnimEditorFrame(0) = AnimEditorFrame(0) + 1
                End If
                AnimEditorTimer(0) = GetTickCount()
                ShouldRender = True
            End If

            If ShouldRender Then
                If FrmEditor_Animation.nudFrameCount0.Value > 0 Then
                    ' total width divided by frame count
                    height = AnimationsGfxInfo(Animationnum).Height
                    width = AnimationsGfxInfo(Animationnum).Width / FrmEditor_Animation.nudFrameCount0.Value
                    With sRECT
                        .Y = 0
                        .Height = height
                        .X = (AnimEditorFrame(0) - 1) * width
                        .Width = width
                    End With
                    With dRECT
                        .Y = 0
                        .Height = height
                        .X = 0
                        .Width = width
                    End With

                    EditorAnimation_Anim1.Clear(ToSfmlColor(FrmEditor_Animation.picSprite0.BackColor))
                    RenderSprite(AnimationsSprite(Animationnum), EditorAnimation_Anim1, dRECT.X, dRECT.Y, sRECT.X,
                                 sRECT.Y, sRECT.Width, sRECT.Height)
                    EditorAnimation_Anim1.Display()
                End If
            End If
        End If

        Animationnum = FrmEditor_Animation.nudSprite1.Value

        If Animationnum < 1 OrElse Animationnum > NumAnimations Then
            EditorAnimation_Anim2.Clear(ToSfmlColor(FrmEditor_Animation.picSprite1.BackColor))
            EditorAnimation_Anim2.Display()
        Else
            If AnimationsGfxInfo(Animationnum).IsLoaded = False Then
                LoadTexture(Animationnum, 6)
            End If

            'seeying we still use it, lets update timer
            With AnimationsGfxInfo(Animationnum)
                .TextureTimer = GetTickCount() + 100000
            End With

            looptime = FrmEditor_Animation.nudLoopTime1.Value
            FrameCount = FrmEditor_Animation.nudFrameCount1.Value
            ShouldRender = False

            ' check if we need to render new frame
            If AnimEditorTimer(1) + looptime <= GetTickCount() Then
                ' check if out of range
                If AnimEditorFrame(1) >= FrameCount Then
                    AnimEditorFrame(1) = 1
                Else
                    AnimEditorFrame(1) = AnimEditorFrame(1) + 1
                End If
                AnimEditorTimer(1) = GetTickCount()
                ShouldRender = True
            End If

            If ShouldRender Then
                If FrmEditor_Animation.nudFrameCount1.Value > 0 Then
                    ' total width divided by frame count
                    height = AnimationsGfxInfo(Animationnum).Height
                    width = AnimationsGfxInfo(Animationnum).Width / FrmEditor_Animation.nudFrameCount1.Value
                    With sRECT
                        .Y = 0
                        .Height = height
                        .X = (AnimEditorFrame(1) - 1) * width
                        .Width = width
                    End With

                    With dRECT
                        .Y = 0
                        .Height = height
                        .X = 0
                        .Width = width
                    End With

                    EditorAnimation_Anim2.Clear(ToSfmlColor(FrmEditor_Animation.picSprite1.BackColor))
                    RenderSprite(AnimationsSprite(Animationnum), EditorAnimation_Anim2, dRECT.X, dRECT.Y, sRECT.X,
                                 sRECT.Y, sRECT.Width, sRECT.Height)
                    EditorAnimation_Anim2.Display()
                End If
            End If
        End If
    End Sub

    Public flickerRandom As Random = New Random()

    Private Function RandomNumberBetween(minValue As Double, maxValue As Double) As Double
        Dim [next] = flickerRandom.NextDouble()
        Return minValue + ([next] * (maxValue - minValue))
    End Function

    Private Function Clamp(value As Integer, min As Integer, max As Integer) As Integer
        Return If((value < min), min, If((value > max), max, value))
    End Function

    Private Function GetCellsInSquare(xCenter As Integer, yCenter As Integer, distance As Integer) As List(Of Vector2i)
        Dim xMin As Integer = Math.Max(0, xCenter - distance)
        Dim xMax As Integer = Math.Min(Map.MaxX, xCenter + distance)
        Dim yMin As Integer = Math.Max(0, yCenter - distance)
        Dim yMax As Integer = Math.Min(Map.MaxY, yCenter + distance)
        Dim cells = New List(Of Vector2i)()

        For y As Integer = yMin To yMax
            For x As Integer = xMin To xMax
                cells.Add(New Vector2i(x, y))
            Next
        Next
        Return cells
    End Function

    Private Function GetBorderCellsInSquare(xCenter As Integer, yCenter As Integer, distance As Integer) _
        As List(Of Vector2i)
        Dim xMin As Integer = Math.Max(0, xCenter - distance)
        Dim xMax As Integer = Math.Min(Map.MaxX, xCenter + distance)
        Dim yMin As Integer = Math.Max(0, yCenter - distance)
        Dim yMax As Integer = Math.Min(Map.MaxY, yCenter + distance)
        Dim borderCells = New List(Of Vector2i)()

        For x As Integer = xMin To xMax
            borderCells.Add(New Vector2i(x, yMin))
            borderCells.Add(New Vector2i(x, yMax))
        Next

        For y As Integer = yMin + 1 To yMax - 1
            borderCells.Add(New Vector2i(xMin, y))
            borderCells.Add(New Vector2i(xMax, y))
        Next

        Dim centerCell = New Vector2i(xCenter, yCenter)
        borderCells.Remove(centerCell)
        Return borderCells
    End Function

    Private Function line(x As Integer, y As Integer, xDestination As Integer, yDestination As Integer) _
        As List(Of Vector2i)
        Dim discovered = New HashSet(Of Vector2i)()
        Dim litTiles = New List(Of Vector2i)()
        Dim dx As Integer = Math.Abs(xDestination - x)
        Dim dy As Integer = Math.Abs(yDestination - y)
        Dim sx As Integer = If(x < xDestination, 1, -1)
        Dim sy As Integer = If(y < yDestination, 1, -1)
        Dim err As Integer = dx - dy

        While True
            Dim pos = New Vector2i(x, y)

            If discovered.Add(pos) Then
                litTiles.Add(pos)
            End If

            If x = xDestination AndAlso y = yDestination Then
                Exit While
            End If

            Dim e2 As Integer = 2 * err

            If e2 > -dy Then
                err = err - dy
                x = x + sx
            ElseIf e2 < dx Then
                err = err + dx
                y = y + sy
            End If
        End While

        Return litTiles
    End Function

    Private Function AppendFov(xOrigin As Integer, yOrigin As Integer, radius As Integer, lightWalls As Boolean) _
        As List(Of Vector2i)
        Dim _inFov = New List(Of Vector2i)()

        For Each borderCell As Vector2i In GetBorderCellsInSquare(xOrigin, yOrigin, radius)

            For Each cell As Vector2i In line(xOrigin, yOrigin, borderCell.X, borderCell.Y)

                If (Math.Abs(cell.X - xOrigin) + Math.Abs(cell.Y - yOrigin)) > radius Then
                    Exit For
                End If

                If IsTransparent(cell.X, cell.Y) Then
                    _inFov.Add(cell)
                Else

                    If lightWalls Then
                        _inFov.Add(cell)
                    End If

                    Exit For
                End If
            Next
        Next

        If lightWalls Then

            For Each cell As Vector2i In GetCellsInSquare(xOrigin, yOrigin, radius)

                If cell.X > xOrigin Then

                    If cell.Y > yOrigin Then
                        PostProcessFovQuadrant(_inFov, cell.X, cell.Y, Quadrant.SE)
                    ElseIf cell.Y < yOrigin Then
                        PostProcessFovQuadrant(_inFov, cell.X, cell.Y, Quadrant.NE)
                    End If
                ElseIf cell.X < xOrigin Then

                    If cell.Y > yOrigin Then
                        PostProcessFovQuadrant(_inFov, cell.X, cell.Y, Quadrant.SW)
                    ElseIf cell.Y < yOrigin Then
                        PostProcessFovQuadrant(_inFov, cell.X, cell.Y, Quadrant.NW)
                    End If
                End If
            Next
        End If

        Return _inFov
    End Function

    Private Sub PostProcessFovQuadrant(ByRef _inFov As List(Of Vector2i), x As Integer, y As Integer,
                                       quadrant As Quadrant)
        Dim x1 As Integer = x
        Dim y1 As Integer = y
        Dim x2 As Integer = x
        Dim y2 As Integer = y
        Dim pos = New Vector2i(x, y)

        Select Case quadrant
            Case Quadrant.NE
                y1 = y + 1
                x2 = x - 1
                Exit Select
            Case Quadrant.SE
                y1 = y - 1
                x2 = x - 1
                Exit Select
            Case Quadrant.SW
                y1 = y - 1
                x2 = x + 1
                Exit Select
            Case Quadrant.NW
                y1 = y + 1
                x2 = x + 1
                Exit Select
        End Select

        If Not _inFov.Contains(pos) AndAlso Not IsTransparent(x, y) Then
            If _
                (IsTransparent(x1, y1) AndAlso _inFov.Contains(New Vector2i(x1, y1))) OrElse
                (IsTransparent(x2, y2) AndAlso _inFov.Contains(New Vector2i(x2, y2))) OrElse
                (IsTransparent(x2, y1) AndAlso _inFov.Contains(New Vector2i(x2, y1))) Then
                _inFov.Add(pos)
            End If
        End If
    End Sub

    Private Function IsTransparent(x As Integer, y As Integer) As Boolean
        If Map.Tile(x, y).Type = TileType.Blocked Then
            Return False
        End If

        Return True
    End Function

    Private Function AddToHashSet(hashSet As HashSet(Of Vector2i), x As Integer, y As Integer, centerCell As Vector2i,
                                  <Out> ByRef cell As Vector2i) As Boolean
        cell = New Vector2i(x, y)

        If Not IsValidMapPoint(x, y) OrElse Map.Tile(x, y).Type = TileType.Blocked Then
            Return False
        End If

        If x = Player(Myindex).X AndAlso y = Player(Myindex).Y Then
            Return False
        End If

        If cell.Equals(centerCell) Then
            Return False
        End If

        Return hashSet.Add(cell)
    End Function

    Public Sub DrawCursor()
        RenderSprite(CursorSprite, GameWindow, CurMouseX, CurMouseY, 0, 0, CursorInfo.Width, CursorInfo.Height)
    End Sub

      Sub DrawHotbar()
        Dim i As Integer, num As Integer, pic As Integer
        Dim rec As Rectangle, recPos As Rectangle

        RenderSprite(HotBarSprite, GameWindow, HotbarX, HotbarY, 0, 0, HotBarGfxInfo.Width, HotBarGfxInfo.Height)

        For i = 1 To MAX_HOTBAR
            If Player(Myindex).Hotbar(i).SlotType = 1 Then
                num = Player(Myindex).Skill(Player(Myindex).Hotbar(i).Slot).Num

                If Num > 0 Then
                    StreamSkill(num)
                    pic = Skill(num).Icon

                    If SkillIconsGfxInfo(pic).IsLoaded = False Then
                        LoadTexture(pic, 9)
                    End If

                    'seeying we still use it, lets update timer
                    With SkillIconsGfxInfo(pic)
                        .TextureTimer = GetTickCount() + 100000
                    End With

                    With rec
                        .Y = 0
                        .Height = 32
                        .X = 0
                        .Width = 32
                    End With

                    If Not Player(Myindex).Skill(i).CD = 0 Then
                        rec.X = 32
                        rec.Width = 32
                    End If

                    With recPos
                        .Y = HotbarY + HotbarTop
                        .Height = PicY
                        .X = HotbarX + HotbarLeft + ((HotbarOffsetX + 32) * (((i - 1))))
                        .Width = PicX
                    End With

                    RenderSprite(SkillIconsSprite(pic), GameWindow, recPos.X, recPos.Y, rec.X, rec.Y, rec.Width, rec.Height)
                End If

            ElseIf Player(Myindex).Hotbar(i).SlotType = 2 Then
                num = Player(Myindex).Inv(Player(Myindex).Hotbar(i).Slot).Num

                If num > 0 Then
                    If num > 0 and Item(num).Name = "" And Item_Changed(num) = False Then
                        Item_Changed(num) = True
                        SendRequestItem(num)
                    End If
                    pic = Item(num).Pic

                    If ItemsGfxInfo(pic).IsLoaded = False Then
                        LoadTexture(pic, 4)
                    End If

                    'seeying we still use it, lets update timer
                    With ItemsGfxInfo(pic)
                        .TextureTimer = GetTickCount() + 100000
                    End With

                    With rec
                        .Y = 0
                        .Height = 32
                        .X = 0
                        .Width = 32
                    End With

                    With recPos
                        .Y = HotbarY + HotbarTop
                        .Height = PicY
                        .X = HotbarX + HotbarLeft + ((HotbarOffsetX + 32) * (((i - 1))))
                        .Width = PicX
                    End With

                    RenderSprite(ItemsSprite(pic), GameWindow, recPos.X, recPos.Y, rec.X, rec.Y, rec.Width, rec.Height)
                End If
            End If
        Next

    End Sub

End Module