﻿module Ploeh.Numsense.SpanishExamples

open Xunit
open Swensen.Unquote

[<Theory>]
[<InlineData(                                             "cero",            0)>]
[<InlineData(                                            " cero",            0)>]
[<InlineData(                                            "cero ",            0)>]
[<InlineData(                                         "  cero  ",            0)>]
[<InlineData(                                             "Cero",            0)>]
[<InlineData(                                             "CERO",            0)>]
[<InlineData(                                          " cERo\t",            0)>]
[<InlineData(                                              "uno",            1)>]
[<InlineData(                                              "UNO",            1)>]
[<InlineData(                                              "dos",            2)>]
[<InlineData(                                             " dos",            2)>]
[<InlineData(                                             "tres",            3)>]
[<InlineData(                                           "tres  ",            3)>]
[<InlineData(                                           "cuatro",            4)>]
[<InlineData(                                        "  cuatro ",            4)>]
[<InlineData(                                            "cinco",            5)>]
[<InlineData(                                            "CinCO",            5)>]
[<InlineData(                                             "seis",            6)>]
[<InlineData(                                         "  SEIS  ",            6)>]
[<InlineData(                                            "siete",            7)>]
[<InlineData(                                        "    siEte",            7)>]
[<InlineData(                                             "ocho",            8)>]
[<InlineData(                                             "oCHO",            8)>]
[<InlineData(                                            "nueve",            9)>]
[<InlineData(                                          "NuEvE  ",            9)>]
[<InlineData(                                             "diez",           10)>]
[<InlineData(                                             "once",           11)>]
[<InlineData(                                             "doce",           12)>]
[<InlineData(                                            "trece",           13)>]
[<InlineData(                                          "catorce",           14)>]
[<InlineData(                                           "quince",           15)>]
[<InlineData(                                        "dieciséis",           16)>]
[<InlineData(                                       "diecisiete",           17)>]
[<InlineData(                                        "dieciocho",           18)>]
[<InlineData(                                       "diecinueve",           19)>]
[<InlineData(                                           "veinte",           20)>]
[<InlineData(                                        "veintiuno",           21)>]
[<InlineData(                                        "veintidós",           22)>]
[<InlineData(                                       "veintitrés",           23)>]
[<InlineData(                                          "treinta",           30)>]
[<InlineData(                                 "treinta y cuatro",           34)>]
[<InlineData(                                   "treinta y ocho",           38)>]
[<InlineData(                                         "cuarenta",           40)>]
[<InlineData(                                   "cuarenta y uno",           41)>]
[<InlineData(                                "cuarenta y cuatro",           44)>]
[<InlineData(                                        "cincuenta",           50)>]
[<InlineData(                                "cincuenta y siete",           57)>]
[<InlineData(                                          "sesenta",           60)>]
[<InlineData(                                  "sesenta y cinco",           65)>]
[<InlineData(                                          "setenta",           70)>]
[<InlineData(                                  "setenta y siete",           77)>]
[<InlineData(                                  "setenta y nueve",           79)>]
[<InlineData(                                          "ochenta",           80)>]
[<InlineData(                                   "ochenta y seis",           86)>]
[<InlineData(                                          "noventa",           90)>]
[<InlineData(                                   "noventa y tres",           93)>]
[<InlineData(                                             "cien",          100)>]
[<InlineData(                                       "ciento uno",          101)>]
[<InlineData(                                "ciento veintitrés",          123)>]
[<InlineData(                                       "doscientos",          200)>]
[<InlineData(                       "doscientos treinta y siete",          237)>]
[<InlineData(                      "trescientos setenta y cinco",          375)>]
[<InlineData(                            "cuatrocientos noventa",          490)>]
[<InlineData(                        "quinientos sesenta y tres",          563)>]
[<InlineData(                            "seiscientos dieciocho",          618)>]
[<InlineData(                      "setecientos setenta y siete",          777)>]
[<InlineData(                                "ochocientos cinco",          805)>]
[<InlineData(                                 "ochocientos seis",          806)>]
[<InlineData(                                "ochocientos siete",          807)>]
[<InlineData(                    "novecientos cincuenta y nueve",          959)>]
[<InlineData(                                              "mil",         1000)>]
[<InlineData(                                          "mil uno",         1001)>]
[<InlineData(                                          "mil dos",         1002)>]
[<InlineData(                             "mil sesenta y cuatro",         1064)>]
[<InlineData(                                          "dos mil",         2000)>]
[<InlineData(                   "ocho mil setecientos veintiuno",         8721)>]
[<InlineData(                      "nueve mil ciento veintitrés",         9123)>]
[<InlineData(                                         "diez mil",        10000)>]
[<InlineData(                              "diez mil ciento uno",        10101)>]
[<InlineData(                              "diez mil ciento dos",        10102)>]
[<InlineData(                          "veintiún mil veintitrés",        21023)>]
[<InlineData(       "veintitrés mil quinientos sesenta y cuatro",        23564)>]
[<InlineData(                                 "ochenta mil diez",        80010)>]
[<InlineData(                                         "cien mil",       100000)>]
[<InlineData(                                     "cien mil uno",       100001)>]
[<InlineData("trescientos diecinueve mil trescientos cuarenta y nueve", 319349)>]
[<InlineData(                                        "un millón",      1000000)>]
[<InlineData(                                    "un millón uno",      1000001)>]
[<InlineData(                                "dos millones diez",      2000010)>]
[<InlineData(                        "seis millones treinta mil",      6030000)>]
[<InlineData("nueve millones doscientos uno mil seiscientos ochenta",  9201680)>]
[<InlineData(                                    "diez millones",     10000000)>]
[<InlineData(                              "diez millones nueve",     10000009)>]
[<InlineData(                                "veintiún millones",     21000000)>]
[<InlineData("cuarenta y siete millones seiscientos sesenta y uno mil sesenta", 47661060)>]
[<InlineData(                                    "cien millones",    100000000)>]
[<InlineData(                        "doscientos cinco millones",    205000000)>]
[<InlineData(                       "trescientos siete millones",    307000000)>]
[<InlineData("cuatrocientos sesenta y un millones sesenta mil seiscientos", 461060600)>]
[<InlineData(                                     "mil millones",   1000000000)>]
[<InlineData(                                      "un millardo",   1000000000)>]
[<InlineData(                                 "dos mil millones",   2000000000)>]
[<InlineData(                                    "dos millardos",   2000000000)>]
[<InlineData("dos mil cuarenta y nueve millones seiscientos cincuenta mil", 2049650000)>]
[<InlineData(
    "dos mil ciento cuarenta y siete millones cuatrocientos ochenta y tres mil seiscientos cuarenta y siete",
    System.Int32.MaxValue)>]
let ``tryParseSpanish returns correct result`` (spanish, expected) =
    let actual = Numeral.tryParseSpanish spanish
    Some expected =! actual

[<Theory>]
[<InlineData(         0, "cero")>]
[<InlineData(         1, "uno")>]
[<InlineData(         2, "dos")>]
[<InlineData(         3, "tres")>]
[<InlineData(         4, "cuatro")>]
[<InlineData(         5, "cinco")>]
[<InlineData(         6, "seis")>]
[<InlineData(         7, "siete")>]
[<InlineData(         8, "ocho")>]
[<InlineData(         9, "nueve")>]
[<InlineData(        10, "diez")>]
[<InlineData(        11, "once")>]
[<InlineData(        12, "doce")>]
[<InlineData(        13, "trece")>]
[<InlineData(        14, "catorce")>]
[<InlineData(        15, "quince")>]
[<InlineData(        16, "dieciséis")>]
[<InlineData(        17, "diecisiete")>]
[<InlineData(        18, "dieciocho")>]
[<InlineData(        19, "diecinueve")>]
[<InlineData(        20, "veinte")>]
[<InlineData(        21, "veintiuno")>]
[<InlineData(        22, "veintidós")>]
[<InlineData(        23, "veintitrés")>]
[<InlineData(        26, "veintiséis")>]
[<InlineData(        30, "treinta")>]
[<InlineData(        34, "treinta y cuatro")>]
[<InlineData(        40, "cuarenta")>]
[<InlineData(        42, "cuarenta y dos")>]
[<InlineData(        50, "cincuenta")>]
[<InlineData(        58, "cincuenta y ocho")>]
[<InlineData(        60, "sesenta")>]
[<InlineData(        65, "sesenta y cinco")>]
[<InlineData(        70, "setenta")>]
[<InlineData(        79, "setenta y nueve")>]
[<InlineData(        80, "ochenta")>]
[<InlineData(        86, "ochenta y seis")>]
[<InlineData(        90, "noventa")>]
[<InlineData(        93, "noventa y tres")>]
[<InlineData(       100, "cien")>]
[<InlineData(       101, "ciento uno")>]
[<InlineData(       110, "ciento diez")>]
[<InlineData(       114, "ciento catorce")>]
[<InlineData(       135, "ciento treinta y cinco")>]
[<InlineData(       200, "doscientos")>]
[<InlineData(       282, "doscientos ochenta y dos")>]
[<InlineData(       331, "trescientos treinta y uno")>]
[<InlineData(       407, "cuatrocientos siete")>]
[<InlineData(       520, "quinientos veinte")>]
[<InlineData(       666, "seiscientos sesenta y seis")>]
[<InlineData(       798, "setecientos noventa y ocho")>]
[<InlineData(       857, "ochocientos cincuenta y siete")>]
[<InlineData(       999, "novecientos noventa y nueve")>]
[<InlineData(      1000, "mil")>]
[<InlineData(      1001, "mil uno")>]
[<InlineData(      1010, "mil diez")>]
[<InlineData(      1066, "mil sesenta y seis")>]
[<InlineData(      1337, "mil trescientos treinta y siete")>]
[<InlineData(      1984, "mil novecientos ochenta y cuatro")>]
[<InlineData(      2015, "dos mil quince")>]
[<InlineData(      3000, "tres mil")>]
[<InlineData(      3297, "tres mil doscientos noventa y siete")>]
[<InlineData(      4080, "cuatro mil ochenta")>]
[<InlineData(      5011, "cinco mil once")>]
[<InlineData(      6025, "seis mil veinticinco")>]
[<InlineData(      7441, "siete mil cuatrocientos cuarenta y uno")>]
[<InlineData(      8513, "ocho mil quinientos trece")>]
[<InlineData(      9000, "nueve mil")>]
[<InlineData(     10000, "diez mil")>]
[<InlineData(     12001, "doce mil uno")>]
[<InlineData(     23456, "veintitrés mil cuatrocientos cincuenta y seis")>]
[<InlineData(     32109, "treinta y dos mil ciento nueve")>]
[<InlineData(     40404, "cuarenta mil cuatrocientos cuatro")>]
[<InlineData(     56789, "cincuenta y seis mil setecientos ochenta y nueve")>]
[<InlineData(     60015, "sesenta mil quince")>]
[<InlineData(     71003, "setenta y un mil tres")>]
[<InlineData(     80522, "ochenta mil quinientos veintidós")>]
[<InlineData(     98765, "noventa y ocho mil setecientos sesenta y cinco")>]
[<InlineData(    100000, "cien mil")>]
[<InlineData(    100001, "cien mil uno")>]
[<InlineData(    100010, "cien mil diez")>]
[<InlineData(    101010, "ciento un mil diez")>]
[<InlineData(    200000, "doscientos mil")>]
[<InlineData(    321000, "trescientos veintiún mil")>]
[<InlineData(    411416, "cuatrocientos once mil cuatrocientos dieciséis")>]
[<InlineData(    530121, "quinientos treinta mil ciento veintiuno")>]
[<InlineData(    600000, "seiscientos mil")>]
[<InlineData(    788000, "setecientos ochenta y ocho mil")>]
[<InlineData(    876540, "ochocientos setenta y seis mil quinientos cuarenta")>]
[<InlineData(    908077, "novecientos ocho mil setenta y siete")>]
[<InlineData(   1000000, "un millón")>]
[<InlineData(   2000002, "dos millones dos")>]
[<InlineData(   3040506, "tres millones cuarenta mil quinientos seis")>]
[<InlineData(   4321000, "cuatro millones trescientos veintiún mil")>]
[<InlineData(   5004621, "cinco millones cuatro mil seiscientos veintiuno")>]
[<InlineData(   6982001, "seis millones novecientos ochenta y dos mil uno")>]
[<InlineData(   7000000, "siete millones")>]
[<InlineData(   8000220, "ocho millones doscientos veinte")>]
[<InlineData(   9099000, "nueve millones noventa y nueve mil")>]
[<InlineData(  10000000, "diez millones")>]
[<InlineData(  24000000, "veinticuatro millones")>]
[<InlineData(  39020011, "treinta y nueve millones veinte mil once")>]
[<InlineData(  40606100, "cuarenta millones seiscientos seis mil cien")>]
[<InlineData(  53000000, "cincuenta y tres millones")>]
[<InlineData(  64000098, "sesenta y cuatro millones noventa y ocho")>]
[<InlineData(  70003190, "setenta millones tres mil ciento noventa")>]
[<InlineData(  80000000, "ochenta millones")>]
[<InlineData(  99000099, "noventa y nueve millones noventa y nueve")>]
[<InlineData( 100000000, "cien millones")>]
[<InlineData( 101101101, "ciento un millones ciento un mil ciento uno")>]
[<InlineData( 209000000, "doscientos nueve millones")>]
[<InlineData( 398000000, "trescientos noventa y ocho millones")>]
[<InlineData( 439011000, "cuatrocientos treinta y nueve millones once mil")>]
[<InlineData( 560400000, "quinientos sesenta millones cuatrocientos mil")>]
[<InlineData( 600010900, "seiscientos millones diez mil novecientos")>]
[<InlineData( 700000000, "setecientos millones")>]
[<InlineData( 800116000, "ochocientos millones ciento dieciséis mil")>]
[<InlineData( 900800007, "novecientos millones ochocientos mil siete")>]
[<InlineData(1000000000, "mil millones")>]
[<InlineData(2121000000, "dos mil ciento veintiún millones")>]
[<InlineData(
    System.Int32.MaxValue,
    "dos mil ciento cuarenta y siete millones cuatrocientos ochenta y tres mil seiscientos cuarenta y siete")>]
let ``toSpanish returns correct result`` (i, expected) =
    let actual = Numeral.toSpanish i
    expected =! actual