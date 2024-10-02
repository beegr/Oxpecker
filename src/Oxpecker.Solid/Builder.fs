﻿namespace Oxpecker.Solid

open System.Runtime.CompilerServices

[<AutoOpen>]
module Builder =

    [<Struct>]
    type HtmlAttribute = { Name: string; Value: obj }

    type HtmlElement = interface end
    type HtmlTag  =
        inherit HtmlElement
    type HtmlContainer  =
        inherit HtmlElement

    type RegularNode() =
        interface HtmlTag
        interface HtmlContainer
    type FragmentNode() =
        interface HtmlContainer
    type VoidNode() =
        interface HtmlTag

    type HtmlContainerFun = HtmlContainer -> unit

    type HtmlContainer with
        member inline _.Combine
            ([<InlineIfLambda>] first: HtmlContainerFun, [<InlineIfLambda>] second: HtmlContainerFun)
            : HtmlContainerFun =
                fun builder ->
                    first builder
                    second builder

        member inline _.Zero() : HtmlContainerFun = ignore

        member inline _.Delay([<InlineIfLambda>] delay: unit -> HtmlContainerFun) : HtmlContainerFun =
            delay()

        member inline _.For(values: #seq<'T>, [<InlineIfLambda>] body: 'T -> HtmlContainerFun) : HtmlContainerFun =
            ignore

        member inline _.Yield(element: #HtmlElement) : HtmlContainerFun = ignore

        member inline _.YieldFrom(elements: #seq<#HtmlElement>) : HtmlContainerFun = ignore

        member inline _.Yield(text: string) : HtmlContainerFun = fun txt -> text |> ignore

        member inline _.Yield(text: int) : HtmlContainerFun = fun txt -> text |> ignore

    type HtmlContainerExtensions =
        [<Extension>]
        static member Run(this: #HtmlContainer, runExpr: HtmlContainerFun) =
            runExpr this
            this
