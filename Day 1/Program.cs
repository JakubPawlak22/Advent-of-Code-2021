﻿using System;
using System.Collections.Generic;

namespace Day_1
{
    class Program
    {
        const string input = "157 158 167 157 148 154 155 156 151 126 125 119 128 136 135 144 159 157 164 163 165 166 163 186 194 197 188 203 225 228 248 263 253 280 279 277 281 282 286 290 292 275 274 282 293 301 307 305 300 296 301 310 302 299 300 308 306 327 329 323 320 324 327 340 336 343 344 345 346 347 365 368 372 373 372 371 380 379 357 380 382 392 400 375 376 374 373 376 394 407 408 406 407 405 406 405 415 399 409 405 406 416 422 423 430 435 437 438 406 413 414 413 429 430 459 454 442 451 473 459 433 434 436 438 441 448 456 460 461 470 469 481 504 502 497 499 498 501 510 516 529 531 533 528 531 529 542 543 546 557 569 571 572 567 564 570 563 581 580 581 574 576 600 596 599 603 593 591 592 591 590 593 598 572 564 566 568 595 617 618 617 616 617 600 634 616 630 595 576 549 548 560 574 580 586 575 578 580 581 582 585 595 599 601 598 603 604 602 607 630 643 648 649 650 651 650 657 658 681 683 686 681 682 684 686 670 669 670 665 671 695 683 709 708 717 714 720 711 715 716 717 719 721 727 728 729 707 706 684 682 689 691 692 703 715 716 710 716 719 720 712 722 723 731 732 741 747 723 751 748 759 766 768 767 749 750 753 754 778 786 788 794 815 830 832 839 849 848 837 836 846 831 813 814 798 814 827 822 830 831 832 841 848 851 847 845 847 846 831 813 816 809 815 821 823 822 831 834 862 863 866 868 872 873 859 852 853 863 862 869 883 887 888 903 934 932 931 932 922 933 937 936 934 939 948 949 951 949 968 974 963 954 940 955 956 971 970 966 965 973 1000 998 1006 1020 1035 1036 1043 1052 1054 1058 1056 1055 1054 1055 1067 1045 1051 1050 1046 1045 1043 1044 1041 1044 1030 1034 1037 1036 1030 1037 1027 1026 1022 1024 1014 1016 1018 990 992 991 992 997 1023 1024 1016 1018 1027 1024 1026 1006 1000 999 1004 1005 1006 1021 1022 1024 1023 1021 1029 1047 1062 1036 1039 1053 1058 1062 1051 1049 1060 1069 1071 1072 1063 1071 1076 1082 1084 1071 1080 1082 1083 1084 1100 1096 1095 1107 1122 1120 1128 1127 1109 1123 1122 1125 1111 1112 1109 1114 1103 1104 1106 1107 1110 1104 1083 1086 1083 1060 1061 1070 1051 1016 1013 1012 1013 1008 1021 1022 1017 1018 1012 1010 1014 1007 1004 1015 1018 1022 1016 1040 1039 1055 1057 1054 1067 1066 1074 1075 1079 1086 1087 1074 1075 1076 1084 1070 1076 1075 1072 1081 1097 1098 1095 1077 1055 1056 1058 1074 1075 1074 1084 1085 1099 1092 1093 1094 1053 1049 1068 1069 1067 1069 1081 1092 1104 1121 1124 1125 1123 1106 1143 1133 1134 1116 1134 1136 1137 1139 1138 1142 1143 1155 1156 1157 1146 1156 1157 1180 1200 1189 1188 1187 1189 1198 1203 1204 1198 1219 1213 1215 1220 1222 1223 1224 1227 1236 1232 1233 1236 1238 1239 1244 1245 1246 1211 1213 1217 1222 1218 1219 1227 1228 1242 1244 1243 1240 1245 1244 1252 1244 1242 1243 1242 1252 1261 1269 1284 1290 1291 1292 1293 1290 1292 1293 1294 1298 1303 1304 1308 1294 1291 1292 1289 1274 1281 1282 1304 1305 1303 1304 1285 1286 1281 1284 1292 1285 1281 1282 1279 1287 1298 1319 1311 1309 1342 1325 1334 1331 1340 1341 1342 1343 1344 1345 1332 1333 1338 1340 1375 1331 1357 1351 1366 1362 1360 1336 1334 1335 1336 1333 1336 1330 1335 1334 1328 1329 1323 1337 1338 1333 1322 1326 1323 1324 1323 1332 1336 1341 1332 1367 1370 1371 1372 1385 1391 1414 1399 1400 1398 1399 1388 1386 1384 1383 1412 1416 1417 1416 1419 1407 1414 1424 1423 1417 1439 1451 1450 1455 1453 1456 1449 1464 1467 1468 1473 1470 1472 1473 1474 1470 1456 1472 1452 1447 1469 1471 1452 1453 1454 1461 1462 1463 1478 1482 1477 1476 1482 1483 1489 1490 1484 1485 1484 1486 1469 1476 1479 1478 1480 1479 1469 1467 1477 1495 1494 1480 1474 1475 1483 1497 1499 1487 1480 1481 1479 1512 1514 1516 1519 1521 1513 1516 1521 1522 1529 1521 1524 1526 1525 1526 1527 1526 1527 1529 1535 1547 1548 1552 1555 1559 1561 1571 1572 1571 1573 1577 1580 1579 1580 1581 1561 1565 1567 1562 1573 1584 1586 1578 1581 1583 1582 1573 1596 1597 1598 1609 1615 1620 1610 1616 1607 1609 1593 1598 1599 1603 1604 1597 1602 1615 1618 1627 1625 1619 1618 1614 1617 1616 1610 1630 1639 1642 1646 1648 1645 1656 1658 1652 1644 1645 1657 1656 1690 1691 1692 1701 1717 1715 1718 1712 1711 1710 1709 1715 1712 1723 1722 1725 1720 1711 1710 1713 1717 1718 1730 1722 1700 1715 1740 1743 1742 1740 1743 1749 1752 1751 1754 1762 1775 1776 1808 1805 1806 1802 1800 1802 1812 1809 1810 1806 1807 1826 1823 1826 1828 1824 1830 1839 1842 1814 1815 1818 1824 1825 1826 1859 1834 1837 1841 1849 1865 1878 1875 1876 1888 1889 1906 1908 1911 1912 1916 1920 1929 1933 1923 1920 1931 1926 1927 1917 1914 1912 1904 1910 1911 1902 1899 1894 1886 1889 1885 1887 1898 1899 1893 1881 1905 1904 1930 1931 1928 1926 1923 1889 1849 1839 1841 1842 1835 1836 1808 1801 1800 1793 1798 1804 1823 1808 1809 1820 1828 1831 1819 1820 1824 1817 1819 1815 1810 1802 1819 1835 1838 1829 1824 1822 1829 1837 1867 1870 1869 1876 1878 1873 1874 1884 1882 1859 1844 1840 1860 1844 1852 1849 1860 1861 1864 1855 1854 1850 1855 1859 1849 1853 1871 1870 1843 1839 1844 1848 1854 1839 1841 1862 1863 1869 1870 1872 1877 1879 1878 1873 1877 1885 1884 1883 1889 1897 1896 1902 1899 1900 1897 1891 1895 1908 1911 1917 1927 1926 1929 1935 1937 1935 1932 1934 1936 1932 1929 1932 1941 1960 1953 1956 1954 1966 1967 1994 2002 1994 2002 2016 2020 2014 2001 1964 1972 1973 1972 1968 1969 1968 1966 1953 1954 1963 1962 1963 1964 1960 1949 1950 1954 1957 1958 1960 1964 1995 1997 1984 1983 2005 2010 2026 2034 2035 2036 2034 2037 2040 2044 2052 2054 2081 2083 2085 2086 2088 2090 2089 2092 2086 2088 2091 2087 2090 2093 2085 2086 2096 2125 2132 2142 2165 2169 2170 2167 2168 2169 2168 2158 2162 2171 2169 2165 2166 2164 2178 2194 2190 2189 2202 2205 2207 2226 2227 2226 2210 2209 2208 2231 2232 2246 2251 2250 2254 2250 2249 2245 2246 2247 2267 2264 2259 2287 2263 2274 2277 2237 2242 2256 2277 2278 2292 2293 2306 2323 2326 2300 2296 2297 2318 2320 2322 2326 2324 2325 2331 2355 2357 2380 2375 2378 2391 2395 2403 2404 2409 2410 2405 2406 2401 2404 2406 2424 2418 2405 2404 2401 2403 2409 2401 2385 2386 2389 2385 2388 2404 2405 2412 2414 2430 2429 2403 2402 2407 2408 2410 2399 2374 2403 2416 2431 2433 2434 2438 2439 2453 2455 2456 2457 2464 2465 2464 2465 2469 2464 2472 2458 2446 2448 2447 2457 2481 2470 2479 2502 2521 2538 2527 2522 2528 2516 2519 2517 2530 2538 2537 2544 2545 2547 2572 2555 2550 2551 2552 2553 2555 2558 2559 2558 2560 2546 2540 2546 2545 2548 2554 2556 2557 2553 2581 2608 2617 2613 2604 2643 2650 2651 2646 2647 2648 2653 2642 2644 2645 2642 2639 2661 2656 2655 2653 2654 2655 2643 2660 2662 2659 2658 2659 2660 2661 2642 2652 2650 2657 2650 2644 2620 2636 2635 2636 2637 2611 2608 2594 2603 2605 2604 2605 2602 2573 2562 2559 2560 2548 2558 2562 2566 2567 2569 2574 2601 2611 2613 2629 2618 2607 2609 2611 2613 2617 2629 2618 2625 2631 2637 2642 2633 2622 2623 2617 2607 2617 2615 2616 2617 2622 2635 2637 2639 2640 2643 2644 2645 2647 2641 2640 2658 2657 2656 2661 2663 2670 2672 2678 2685 2686 2683 2684 2687 2689 2691 2703 2708 2714 2718 2717 2720 2740 2741 2749 2732 2738 2744 2749 2750 2747 2738 2733 2760 2747 2748 2749 2750 2759 2767 2771 2778 2776 2774 2758 2750 2751 2753 2755 2766 2774 2778 2772 2776 2775 2777 2774 2794 2795 2796 2799 2800 2797 2827 2824 2825 2830 2841 2839 2838 2840 2835 2836 2853 2852 2869 2877 2890 2892 2889 2894 2904 2901 2907 2911 2915 2924 2932 2933 2912 2928 2931 2939 2941 2940 2941 2931 2930 2926 2897 2899 2887 2879 2899 2898 2903 2908 2911 2910 2927 2930 2923 2933 2945 2961 2971 2972 2973 2974 2973 2987 2989 2988 2992 3003 2995 2996 2983 2984 2989 2998 3007 3006 2991 3023 3013 3004 3006 3017 3021 3033 3031 3034 3018 3017 3019 3017 3023 3046 3059 3066 3063 3060 3058 3061 3062 3070 3078 3082 3087 3090 3118 3117 3125 3127 3133 3138 3154 3146 3147 3141 3149 3157 3160 3166 3174 3187 3188 3200 3203 3218 3221 3220 3248 3249 3244 3241 3242 3240 3214 3213 3230 3229 3227 3223 3219 3210 3224 3220 3240 3232 3229 3218 3224 3242 3241 3244 3267 3281 3286 3287 3303 3304 3314 3318 3307 3292 3331 3332 3334 3339 3348 3356 3374 3405 3406 3408 3411 3407 3399 3402 3403 3405 3395 3394 3393 3394 3382 3388 3374 3376 3371 3373 3403 3404 3395 3401 3418 3419 3420 3423 3424 3412 3401 3402 3401 3413 3419 3421 3391 3384 3392 3393 3401 3404 3407 3408 3410 3426 3427 3431 3430 3448 3449 3451 3458 3463 3443 3442 3432 3423 3437 3439 3419 3426 3427 3426 3425 3426 3428 3429 3436 3435 3443 3433 3448 3446 3449 3445 3439 3447 3440 3456 3443 3467 3478 3473 3487 3486 3484 3494 3492 3489 3497 3500 3488 3487 3488 3491 3487 3511 3520 3515 3512 3504 3509 3502 3505 3508 3511 3512 3513 3515 3516 3519 3524 3519 3520 3518 3529 3535 3539 3551 3560 3559 3567 3571 3569 3570 3556 3559 3538 3541 3542 3548 3535 3533 3539 3549 3545 3546 3541 3527 3528 3564 3565 3568 3571 3569 3574 3578 3583 3585 3601 3598 3620 3621 3638 3621 3623 3602 3605 3600 3601 3602 3582 3584 3574 3570 3572 3563 3564 3565 3557 3556 3557 3558 3555 3560 3565 3564 3552 3560 3559 3589 3592 3590 3605 3617 3599 3600 3608 3589 3593 3600 3598 3596 3597 3598 3610 3611 3631 3637 3660 3661 3673 3680 3681 3680 3676 3677 3678 3664 3656 3655 3640 3637 3635 3636 3639 3621 3608 3592 3606 3605 3601 3603 3620 3619 3617 3609 3612 3610 3599 3606 3602 3605 3604 3606 3615 3617 3619 3620 3626 3627 3626 3625 3640 3653 3625 3617 3620 3623 3633 3627 3598 3607 3606 3611 3610 3609 3611 3612 3620 3621 3602 3593 3594 3593 3594 3602 3603 3610 3596 3600 3604 3601 3604 3605 3582 3579 3568 3569 3576 3584 3586 3566 3563 3571 3581 3586 3601 3584 3574 3585 3574 3584 3581 3585 3576 3578 3593 3618 3623 3624 3628 3636 3638 3643 3648 3641 3664 3662 3675 3690 3697 3698 3695 3696 3694 3685 3686 3687 3684 3693 3687 3704 3710 3711 3715 3710 3705 3692 3704 3709 3724 3725 3729 3722 3723 3712 3716 3717 3741 3714 3700 3716 3710 3711 3733 3734 3737 3728 3729 3739 3743 3746 3756 3763 3794 3798";
        static void Main(string[] args)
        {
            var inputs = ConvertStringToInts(input);
            var result = CheckNumberOfIncreasing(inputs);
            Console.WriteLine(result);
        }

        private static int CheckNumberOfIncreasing(List<int> inputs)
        {
            var result = 0;
            for (int i = 3; i < inputs.Count; i++)
            {
                if (inputs[i] > inputs[i - 3])
                    result++;
            }
            for (int i = 1; i < inputs.Count; i++)
            {
                if (inputs[i] > inputs[i - 1])
                    result++;
            }
            return result;
        }

        private static List<int> ConvertStringToInts(string input)
        {
            string[] textInputs = input.Split(' ');
            var inputs = new List<int>();
            foreach (var textInput in textInputs)
            {
                try
                {
                    var success = Int32.TryParse(textInput, out int value);
                    if (success)
                    {
                        inputs.Add(value);
                    }
                }
                catch
                {

                }
            }
            return inputs;
        }
    }
}
