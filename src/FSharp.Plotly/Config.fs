namespace FSharp.Plotly

//Missing imploementations (from full attributes from the plotly docs) :
//To string: -> edits: {AnnotationEditOptions}
type AnnotationEditOptions =
///Determines if the main anchor of the annotation is editable.The main anchor corresponds to the',
///text (if no arrow) or the arrow (which drags the whole thing leaving the arrow length & direction unchanged).
|AnnotationPosition
///Has only an effect for annotations with arrows. Enables changing the length and direction of the arrow.
|AnnotationTail
///Enables editing annotation text.
|AnnotationText
///Enables editing axis title text.
|AxisTitleText
///Enables moving colorbars.
|ColorbarPosition
///Enables editing colorbar title text.
|ColorbarTitleText
///Enables moving the legend.
|LegendPosition
///Enables editing the trace name fields from the legend
|LegendText
///Enables moving shapes.
|ShapePosition
    
    static member toString aeo =
        match aeo with
        |AnnotationPosition ->  "annotationPosition" 
        |AnnotationTail     ->  "annotationTail"     
        |AnnotationText     ->  "annotationText"     
        |AxisTitleText      ->  "axisTitleText"      
        |ColorbarPosition   ->  "colorbarPosition"   
        |ColorbarTitleText  ->  "colorbarTitleText"  
        |LegendPosition     ->  "legendPosition"     
        |LegendText         ->  "legendText"         
        |ShapePosition      ->  "shapePosition"      



//    fillFrame: {
//        valType: 'boolean',
//        dflt: false,
//        description: [
//            'When `layout.autosize` is turned on, determines whether the graph',
//            'fills the container (the default) or the screen (if set to *true*).'
//        ].join(' ')
//    },
//    frameMargins: {
//        valType: 'number',
//        dflt: 0,
//        min: 0,
//        max: 0.5,
//        description: [
//            'When `layout.autosize` is turned on, set the frame margins',
//            'in fraction of the graph size.'
//        ].join(' ')
//    },

//    scrollZoom: {
//        valType: 'flaglist',
//        flags: ['cartesian', 'gl3d', 'geo', 'mapbox'],
//        extras: [true, false],
//        dflt: 'gl3d+geo+mapbox',
//        description: [
//            'Determines whether mouse wheel or two-finger scroll zooms is enable.',
//            'Turned on by default for gl3d, geo and mapbox subplots',
//            '(as these subplot types do not have zoombox via pan),',
//            'but turned off by default for cartesian subplots.',
//            'Set `scrollZoom` to *false* to disable scrolling for all subplots.'
//        ].join(' ')
//    },
//    doubleClick: {
//        valType: 'enumerated',
//        values: [false, 'reset', 'autosize', 'reset+autosize'],
//        dflt: 'reset+autosize',
//        description: [
//            'Sets the double click interaction mode.',
//            'Has an effect only in cartesian plots.',
//            'If *false*, double click is disable.',
//            'If *reset*, double click resets the axis ranges to their initial values.',
//            'If *autosize*, double click set the axis ranges to their autorange values.',
//            'If *reset+autosize*, the odd double clicks resets the axis ranges',
//            'to their initial values and even double clicks set the axis ranges',
//            'to their autorange values.'
//        ].join(' ')
//    },
//    doubleClickDelay: {
//        valType: 'number',
//        dflt: 300,
//        min: 0,
//        description: [
//            'Sets the delay for registering a double-click in ms.',
//            'This is the time interval (in ms) between first mousedown and',
//            '2nd mouseup to constitute a double-click.',
//            'This setting propagates to all on-subplot double clicks',
//            '(except for geo and mapbox) and on-legend double clicks.'
//        ].join(' ')
//    },

//    showAxisDragHandles: {
//        valType: 'boolean',
//        dflt: true,
//        description: [
//            'Set to *false* to omit cartesian axis pan/zoom drag handles.'
//        ].join(' ')
//    },
//    showAxisRangeEntryBoxes: {
//        valType: 'boolean',
//        dflt: true,
//        description: [
//            'Set to *false* to omit direct range entry at the pan/zoom drag points,',
//            'note that `showAxisDragHandles` must be enabled to have an effect.'
//        ].join(' ')
//    },

//    showTips: {
//        valType: 'boolean',
//        dflt: true,
//        description: [
//            'Determines whether or not tips are shown while interacting',
//            'with the resulting graphs.'
//        ].join(' ')
//    },

//    showLink: {
//        valType: 'boolean',
//        dflt: false,
//        description: [
//            'Determines whether a link to plot.ly is displayed',
//            'at the bottom right corner of resulting graphs.',
//            'Use with `sendData` and `linkText`.'
//        ].join(' ')
//    },
//    linkText: {
//        valType: 'string',
//        dflt: 'Edit chart',
//        noBlank: true,
//        description: [
//            'Sets the text appearing in the `showLink` link.'
//        ].join(' ')
//    },
//    sendData: {
//        valType: 'boolean',
//        dflt: true,
//        description: [
//            'If *showLink* is true, does it contain data',
//            'just link to a plot.ly file?'
//        ].join(' ')
//    },
//    showSources: {
//        valType: 'any',
//        dflt: false,
//        description: [
//            'Adds a source-displaying function to show sources on',
//            'the resulting graphs.'
//        ].join(' ')
//    },

//    displayModeBar: {
//        valType: 'enumerated',
//        values: ['hover', true, false],
//        dflt: 'hover',
//        description: [
//            'Determines the mode bar display mode.',
//            'If *true*, the mode bar is always visible.',
//            'If *false*, the mode bar is always hidden.',
//            'If *hover*, the mode bar is visible while the mouse cursor',
//            'is on the graph container.'
//        ].join(' ')
//    },
//    showSendToCloud: {
//        valType: 'boolean',
//        dflt: false,
//        description: [
//            'Should we include a ModeBar button, labeled "Edit in Chart Studio",',
//            'that sends this chart to plot.ly or another plotly server as specified',
//            'by `plotlyServerURL` for editing, export, etc? Prior to version 1.43.0',
//            'this button was included by default, now it is opt-in using this flag.',
//            'Note that this button can (depending on `plotlyServerURL`) send your data',
//            'to an external server. However that server does not persist your data',
//            'until you arrive at the Chart Studio and explicitly click "Save".'
//        ].join(' ')
//    },
//    showEditInChartStudio: {
//        valType: 'boolean',
//        dflt: false,
//        description: [
//            'Same as `showSendToCloud`, but use a pencil icon instead of a floppy-disk.',
//            'Note that if both `showSendToCloud` and `showEditInChartStudio` are turned,',
//            'only `showEditInChartStudio` will be honored.'
//        ].join(' ')
//    },
//    modeBarButtonsToRemove: {
//        valType: 'any',
//        dflt: [],
//        description: [
//            'Remove mode bar buttons by name.',
//            'See ./components/modebar/buttons.js for the list of names.'
//        ].join(' ')
//    },
//    modeBarButtonsToAdd: {
//        valType: 'any',
//        dflt: [],
//        description: [
//            'Add mode bar button using config objects',
//            'See ./components/modebar/buttons.js for list of arguments.'
//        ].join(' ')
//    },
//    modeBarButtons: {
//        valType: 'any',
//        dflt: false,
//        description: [
//            'Define fully custom mode bar buttons as nested array,',
//            'where the outer arrays represents button groups, and',
//            'the inner arrays have buttons config objects or names of default buttons',
//            'See ./components/modebar/buttons.js for more info.'
//        ].join(' ')
//    },
//    toImageButtonOptions: {
//        valType: 'any',
//        dflt: {},
//        description: [
//            'Statically override options for toImage modebar button',
//            'allowed keys are format, filename, width, height, scale',
//            'see ../components/modebar/buttons.js'
//        ].join(' ')
//    },
//    displaylogo: {
//        valType: 'boolean',
//        dflt: true,
//        description: [
//            'Determines whether or not the plotly logo is displayed',
//            'on the end of the mode bar.'
//        ].join(' ')
//    },
//    watermark: {
//        valType: 'boolean',
//        dflt: false,
//        description: 'watermark the images with the company\'s logo'
//    },

//    plotGlPixelRatio: {
//        valType: 'number',
//        dflt: 2,
//        min: 1,
//        max: 4,
//        description: [
//            'Set the pixel ratio during WebGL image export.',
//            'This config option was formerly named `plot3dPixelRatio`',
//            'which is now deprecated.'
//        ].join(' ')
//    },

//    setBackground: {
//        valType: 'any',
//        dflt: 'transparent',
//        description: [
//            'Set function to add the background color (i.e. `layout.paper_color`)',
//            'to a different container.',
//            'This function take the graph div as first argument and the current background',
//            'color as second argument.',
//            'Alternatively, set to string *opaque* to ensure there is white behind it.'
//        ].join(' ')
//    },

//    topojsonURL: {
//        valType: 'string',
//        noBlank: true,
//        dflt: 'https://cdn.plot.ly/',
//        description: [
//            'Set the URL to topojson used in geo charts.',
//            'By default, the topojson files are fetched from cdn.plot.ly.',
//            'For example, set this option to:',
//            '<path-to-plotly.js>/dist/topojson/',
//            'to render geographical feature using the topojson files',
//            'that ship with the plotly.js module.'
//        ].join(' ')
//    },

//    mapboxAccessToken: {
//        valType: 'string',
//        dflt: null,
//        description: [
//            'Mapbox access token (required to plot mapbox trace types)',
//            'If using an Mapbox Atlas server, set this option to \'\'',
//            'so that plotly.js won\'t attempt to authenticate to the public Mapbox server.'
//        ].join(' ')
//    },

//    logging: {
//        valType: 'boolean',
//        dflt: 1,
//        description: [
//            'Turn all console logging on or off (errors will be thrown)',
//            'This should ONLY be set via Plotly.setPlotConfig',
//            'Available levels:',
//            '0: no logs',
//            '1: warnings and errors, but not informational messages',
//            '2: verbose logs'
//        ].join(' ')
//    },

//    queueLength: {
//        valType: 'integer',
//        min: 0,
//        dflt: 0,
//        description: 'Sets the length of the undo/redo queue.'
//    },

//    globalTransforms: {
//        valType: 'any',
//        dflt: [],
//        description: [
//            'Set global transform to be applied to all traces with no',
//            'specification needed'
//        ].join(' ')
//    },

//    locale: {
//        valType: 'string',
//        dflt: 'en-US',
//        description: [
//            'Which localization should we use?',
//            'Should be a string like \'en\' or \'en-US\'.'
//        ].join(' ')
//    },

//    locales: {
//        valType: 'any',
//        dflt: {},
//        description: [
//            'Localization definitions',
//            'Locales can be provided either here (specific to one chart) or globally',
//            'by registering them as modules.',
//            'Should be an object of objects {locale: {dictionary: {...}, format: {...}}}',
//            '{',
//            '  da: {',
//            '      dictionary: {\'Reset axes\': \'Nulstil aksler\', ...},',
//            '      format: {months: [...], shortMonths: [...]}',
//            '  },',
//            '  ...',
//            '}',
//            'All parts are optional. When looking for translation or format fields, we',
//            'look first for an exact match in a config locale, then in a registered',
//            'module. If those fail, we strip off any regionalization (\'en-US\' -> \'en\')',
//            'and try each (config, registry) again. The final fallback for translation',
//            'is untranslated (which is US English) and for formats is the base English',
//            '(the only consequence being the last fallback date format %x is DD/MM/YYYY',
//            'instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored',
//            'for our automatic number formatting, but can be used in custom formats.'
//        ].join(' ')
//    }
//};

type ToImageButtonOptions() =
    inherit DynamicObj()
    static member init 
        (
            ?Format     : StyleParam.ImageFormat,
            ?Filename   : string, 
            ?Width      : float, 
            ?Height     : float, 
            ?Scale      : float
        ) =
            ToImageButtonOptions()
            |> ToImageButtonOptions.style 
                (
                    ?Format     = Format  ,
                    ?Filename   = Filename,
                    ?Width      = Width   ,
                    ?Height     = Height  ,
                    ?Scale      = Scale   
                )
    
    static member style 
        (
            ?Format,
            ?Filename, 
            ?Width, 
            ?Height, 
            ?Scale
        ) =
            fun (btnConf:ToImageButtonOptions) ->
                Format              |> Option.map StyleParam.ImageFormat.toString |> DynObj.setValueOpt btnConf "format"
                Filename            |> DynObj.setValueOpt btnConf "filename"
                Width               |> DynObj.setValueOpt btnConf "width"
                Height              |> DynObj.setValueOpt btnConf "height"
                Scale               |> DynObj.setValueOpt btnConf "scale"
                btnConf
/// Config 
type Config() = 
    inherit DynamicObj ()

    /// Init Legend type
    static member init 
        (
            ?StaticPlot             : bool,
            ?Autosizable            : bool,
            ?Responsive             : bool,
            ?ShowEditInChartStudio  : bool,
            ?ToImageButtonOptions   : ToImageButtonOptions,
            ?Editable               : bool,
            ?EditableAnnotations    : seq<AnnotationEditOptions>
        ) = 
            Config()
            |> Config.style
                (
                    ?StaticPlot             = StaticPlot,
                    ?Autosizable            = Autosizable,
                    ?Responsive             = Responsive,
                    ?ToImageButtonOptions   = ToImageButtonOptions,
                    ?ShowEditInChartStudio  = ShowEditInChartStudio,
                    ?Editable               = Editable,
                    ?EditableAnnotations    = EditableAnnotations
                )


    // Applies the styles to Config()
    static member style
        (   
//          'Statically override options for toImage modebar button',
//            'allowed keys are format, filename, width, height, scale',
            ?StaticPlot             : bool,
            ?Autosizable            : bool,
            ?Responsive             : bool,
            ?ToImageButtonOptions   : ToImageButtonOptions,
            ?ShowEditInChartStudio  : bool,
            ?Editable               : bool,
            ?EditableAnnotations    : seq<AnnotationEditOptions>

        ) =
            fun (config:Config) ->
                StaticPlot              |> DynObj.setValueOpt config "staticPlot" 
                Autosizable             |> DynObj.setValueOpt config "autosizable" 
                Responsive              |> DynObj.setValueOpt config "responsive"
                ToImageButtonOptions    |> DynObj.setValueOpt config "toImageButtonOptions"
                ShowEditInChartStudio   |> DynObj.setValueOpt config "showEditInChartStudio"
                Editable                |> DynObj.setValueOpt config "editable"
                EditableAnnotations
                |> Option.map 
                    (fun edits ->
                        let ed = DynamicObj()
                        edits 
                        |> Seq.iter 
                            (fun edit -> 
                                let fieldName =
                                    AnnotationEditOptions.toString edit
                                ed?(fieldName) <- true
                            )
                        ed
                    )
                |> DynObj.setValueOpt config "edits"

                config