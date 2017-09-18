#! /bin/bash

function generate() {
    nuget pack $1.nuspec
}

frameworks=(
    fresco-core
    fresco-drawee
    fresco-imgpipeline
    fresco-imgpipeline-base
    fresco
)
for framework in "${frameworks[@]}"
do
generate $framework
done