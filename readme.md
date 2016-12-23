// * Summary *

BenchmarkDotNet=v0.10.1, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-4702HQ CPU 2.20GHz, ProcessorCount=8
Frequency=2143483 Hz, Resolution=466.5304 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1586.0

Allocated=0 B

      Method |  I |  J |      Mean |    StdErr |    StdDev |
------------ |--- |--- |---------- |---------- |---------- |
  FirstArray |  0 |  0 | 0.9325 ns | 0.0072 ns | 0.0270 ns |
 SecondArray |  0 |  0 | 0.8229 ns | 0.0041 ns | 0.0157 ns |
  FirstArray |  0 | 25 | 0.9116 ns | 0.0043 ns | 0.0167 ns |
 SecondArray |  0 | 25 | 0.8348 ns | 0.0062 ns | 0.0234 ns |
  FirstArray |  0 | 50 | 0.9432 ns | 0.0063 ns | 0.0244 ns |
 SecondArray |  0 | 50 | 0.8079 ns | 0.0065 ns | 0.0253 ns |
  FirstArray |  0 | 75 | 0.9398 ns | 0.0043 ns | 0.0160 ns |
 SecondArray |  0 | 75 | 0.8443 ns | 0.0052 ns | 0.0202 ns |
  FirstArray |  0 | 99 | 0.9419 ns | 0.0033 ns | 0.0120 ns |
 SecondArray |  0 | 99 | 0.8187 ns | 0.0059 ns | 0.0229 ns |
  FirstArray | 25 |  0 | 0.9411 ns | 0.0072 ns | 0.0279 ns |
 SecondArray | 25 |  0 | 0.8488 ns | 0.0048 ns | 0.0187 ns |
  FirstArray | 25 | 25 | 0.9319 ns | 0.0046 ns | 0.0176 ns |
 SecondArray | 25 | 25 | 0.8183 ns | 0.0056 ns | 0.0202 ns |
  FirstArray | 25 | 50 | 0.9329 ns | 0.0084 ns | 0.0325 ns |
 SecondArray | 25 | 50 | 0.7834 ns | 0.0031 ns | 0.0122 ns |
  FirstArray | 25 | 75 | 0.9063 ns | 0.0044 ns | 0.0171 ns |
 SecondArray | 25 | 75 | 0.8023 ns | 0.0044 ns | 0.0171 ns |
  FirstArray | 25 | 99 | 0.9327 ns | 0.0039 ns | 0.0146 ns |
 SecondArray | 25 | 99 | 0.7990 ns | 0.0055 ns | 0.0214 ns |
  FirstArray | 50 |  0 | 0.9479 ns | 0.0087 ns | 0.0336 ns |
 SecondArray | 50 |  0 | 0.8232 ns | 0.0047 ns | 0.0182 ns |
  FirstArray | 50 | 25 | 0.9368 ns | 0.0052 ns | 0.0203 ns |
 SecondArray | 50 | 25 | 0.8067 ns | 0.0032 ns | 0.0114 ns |
  FirstArray | 50 | 50 | 0.9663 ns | 0.0037 ns | 0.0127 ns |
 SecondArray | 50 | 50 | 0.8251 ns | 0.0077 ns | 0.0298 ns |
  FirstArray | 50 | 75 | 0.9270 ns | 0.0057 ns | 0.0223 ns |
 SecondArray | 50 | 75 | 0.8341 ns | 0.0039 ns | 0.0141 ns |
  FirstArray | 50 | 99 | 0.9163 ns | 0.0040 ns | 0.0149 ns |
 SecondArray | 50 | 99 | 0.8295 ns | 0.0018 ns | 0.0063 ns |
  FirstArray | 75 |  0 | 0.9176 ns | 0.0056 ns | 0.0217 ns |
 SecondArray | 75 |  0 | 0.8205 ns | 0.0036 ns | 0.0137 ns |
  FirstArray | 75 | 25 | 0.9356 ns | 0.0024 ns | 0.0083 ns |
 SecondArray | 75 | 25 | 0.8327 ns | 0.0052 ns | 0.0201 ns |
  FirstArray | 75 | 50 | 0.9239 ns | 0.0024 ns | 0.0094 ns |
 SecondArray | 75 | 50 | 0.8139 ns | 0.0058 ns | 0.0223 ns |
  FirstArray | 75 | 75 | 0.9672 ns | 0.0096 ns | 0.0370 ns |
 SecondArray | 75 | 75 | 0.8482 ns | 0.0048 ns | 0.0188 ns |
  FirstArray | 75 | 99 | 0.9299 ns | 0.0051 ns | 0.0182 ns |
 SecondArray | 75 | 99 | 0.8005 ns | 0.0063 ns | 0.0245 ns |
  FirstArray | 99 |  0 | 0.9243 ns | 0.0029 ns | 0.0111 ns |
 SecondArray | 99 |  0 | 0.8193 ns | 0.0057 ns | 0.0220 ns |
  FirstArray | 99 | 25 | 0.9326 ns | 0.0110 ns | 0.0426 ns |
 SecondArray | 99 | 25 | 0.8424 ns | 0.0054 ns | 0.0210 ns |
  FirstArray | 99 | 50 | 0.9441 ns | 0.0049 ns | 0.0184 ns |
 SecondArray | 99 | 50 | 0.8444 ns | 0.0028 ns | 0.0110 ns |
  FirstArray | 99 | 75 | 0.9286 ns | 0.0124 ns | 0.0480 ns |
 SecondArray | 99 | 75 | 0.8225 ns | 0.0054 ns | 0.0203 ns |
  FirstArray | 99 | 99 | 0.9339 ns | 0.0038 ns | 0.0142 ns |
 SecondArray | 99 | 99 | 0.8151 ns | 0.0041 ns | 0.0158 ns |