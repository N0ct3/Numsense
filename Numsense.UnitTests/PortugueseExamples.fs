﻿module Ploeh.Numsense.PortugueseExamples

open Xunit
open Swensen.Unquote

[<Theory>]
[<InlineData(                                             "zero",          0)>]
[<InlineData(                                            " zero",          0)>]
[<InlineData(                                            "zero ",          0)>]
[<InlineData(                                         "  zero  ",          0)>]
[<InlineData(                                             "Zero",          0)>]
[<InlineData(                                             "ZERO",          0)>]
[<InlineData(                                          " zERo\t",          0)>]
[<InlineData(                                               "um",          1)>]
[<InlineData(                                               "UM",          1)>]
[<InlineData(                                             "dois",          2)>]
[<InlineData(                                            " dois",          2)>]
[<InlineData(                                             "três",          3)>]
[<InlineData(                                           "três  ",          3)>]
[<InlineData(                                           "quatro",          4)>]
[<InlineData(                                        "  quatro ",          4)>]
[<InlineData(                                            "cinco",          5)>]
[<InlineData(                                            "CiNcO",          5)>]
[<InlineData(                                             "seis",          6)>]
[<InlineData(                                         "  seis  ",          6)>]
[<InlineData(                                             "sete",          7)>]
[<InlineData(                                         "    seTe",          7)>]
[<InlineData(                                             "oito",          8)>]
[<InlineData(                                             "oITO",          8)>]
[<InlineData(                                             "nove",          9)>]
[<InlineData(                                           "nOvE  ",          9)>]
[<InlineData(                                              "dez",         10)>]
[<InlineData(                                             "onze",         11)>]
[<InlineData(                                             "doze",         12)>]
[<InlineData(                                            "treze",         13)>]
[<InlineData(                                         "quatorze",         14)>]
[<InlineData(                                          "catorze",         14)>]
[<InlineData(                                           "quinze",         15)>]
[<InlineData(                                          "sixteen",         16)>]
[<InlineData(                                        "dezassete",         17)>]
[<InlineData(                                          "dezoito",         18)>]
[<InlineData(                                         "dezanove",         19)>]
[<InlineData(                                            "vinte",         20)>]
[<InlineData(                                         "vinteeum",         21)>]
[<InlineData(                                       "vinte-e-um",         21)>]
[<InlineData(                                           "trinta",         30)>]
[<InlineData(                                    "trintaequatro",         34)>]
[<InlineData(                                     "thirty-eight",         38)>]
[<InlineData(                                         "quarenta",         40)>]
[<InlineData(                                    "quarenta-e-um",         41)>]
[<InlineData(                                "quarenta-e-quatro",         44)>]
[<InlineData(                                        "cinquenta",         50)>]
[<InlineData(                                   "cinquantaesete",         57)>]
[<InlineData(                                         "sessenta",         60)>]
[<InlineData(                                   "sessentaecinco",         65)>]
[<InlineData(                                          "setenta",         70)>]
[<InlineData(                                   "setenta-e-sete",         77)>]
[<InlineData(                                     "setentaenove",         79)>]
[<InlineData(                                          "oitenta",         80)>]
[<InlineData(                                     "oitentaeseis",         86)>]
[<InlineData(                                          "noventa",         90)>]
[<InlineData(                                     "noventaetrês",         93)>]
[<InlineData(                                              "cem",        100)>]
[<InlineData(                                         "centoeum",        101)>]
[<InlineData(                                       "cento-e-um",        101)>]
[<InlineData(                                         "duzentos",        200)>]
[<InlineData(                             "duzentosetrintaesete",        237)>]
[<InlineData(                          "trezentosesetentaecinco",        375)>]
[<InlineData(                             "quatrocentosenoventa",        490)>]
[<InlineData(                         "quinhentosesessentaetrês",        563)>]
[<InlineData(                               "seiscentosedezoito",        618)>]
[<InlineData(                         "setessentosesetentaesete",        777)>]
[<InlineData(                                 "oitocentosecinco",        805)>]
[<InlineData(                                  "oitocentoseseis",        806)>]
[<InlineData(                        "novecentosecinquentaenove",        959)>]
[<InlineData(                                              "mil",       1000)>]
[<InlineData(                                           "mileum",       1001)>]
[<InlineData(                                         "miledois",       1002)>]
[<InlineData(                              "milesessentaequatro",       1064)>]
[<InlineData(                                          "doismil",       2000)>]
[<InlineData(                      "oitomilsetessentosevinteeum",       8721)>]
[<InlineData(                          "novemilcentoevinteetrês",       9123)>]
[<InlineData(                                           "dezmil",      10000)>]
[<InlineData(                                   "dezmilcentoeum",      10101)>]
[<InlineData(                                 "dezmilcentoedois",      10102)>]
[<InlineData(          "vinteetrêsmilquinhentosesessentaequatro",      23564)>]
[<InlineData(                                   "oitentamiledez",      80010)>]
[<InlineData(                                           "cemmil",     100000)>]
[<InlineData(                                        "cemmileum",     100001)>]
[<InlineData(     "trezentosedezanovemiltrezentosequarentaenove",     319349)>]
[<InlineData(                                         "ummilhão",    1000000)>]
[<InlineData(                                       "umilhãoeum",    1000001)>]
[<InlineData(                                  "doismilhõesedez",    2000010)>]
[<InlineData(                            "seismilhõesetrintamil",    6030000)>]
[<InlineData(      "novemilhõesduzentoseummilseiscentoseoitenta",    9201680)>]
[<InlineData(                                       "dezmilhões",   10000000)>]
[<InlineData(                                  "dezmilhõesenove",   10000009)>]
[<InlineData(                                  "vinteeummilhões",   21000000)>]
[<InlineData(
        "quarentaesetemilhõesseiscentosesessentaeummilesessenta",   47661060)>]
[<InlineData(                                       "cemmilhões",  100000000)>]
[<InlineData(                            "duzentosecincomilhões",  205000000)>]
[<InlineData(                         "trezentos-e-sete-milhões",  307000000)>]
[<InlineData(
         "quatrocentosesessentaeummilhõessessentamileseiscentos",  461060600)>]
[<InlineData(                                       "milmilhões", 1000000000)>]
[<InlineData(                                   "doismilmilhões", 2000000000)>]
[<InlineData(
           "doismilequarentaenovemilhõesseiscentosecinquentamil", 2049650000)>]
[<InlineData(
    "doismilcentoequarentaesetemilhõesquatrocentoseoitentaetrêsmilseiscentosequarentaesete",
    System.Int32.MaxValue)>]
let ``tryOfPortuguese returns correct result`` (portuguese, expected) =
    let actual = Numeral.tryParsePortuguese portuguese
    Some expected =! actual