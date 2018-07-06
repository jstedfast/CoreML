#!/bin/bash

SRC_DIR=external/coremltools/mlmodel/format
DST_DIR=CoreML

protoc -I=$SRC_DIR --csharp_out=$DST_DIR $SRC_DIR/Model.proto
