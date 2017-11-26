# SSD-Schema
Sample files used in discussing a modified version of the SSD-schema for EFSA SSD2. 

This schema does not have any of the needed details such as mandatory or min occurence added yet. It is only to be used as a proof of concept. 

The major idea of this new schema is to move from reporting looking like this


```xml
<sampAnInfo>compY=2015$compM=1$compD=1$com=any relevant comment</sampAnInfo>
```
or this.
```xml
<sampAnInfo>
<value name=“compY”>2015</value>
<value name=“compM”>1</value>
<value name=“compD”>1</value>
<value name=“com”>any relevant comment</value>
</sampAnInfo>
```


to this:
```xml
  <sampAnInfo>
    <compY>2016</compY>
    <compM>1</compM>
    <compD>1</compD>
  </sampAnInfo>
```

which in most cases is easier to parse and create.
