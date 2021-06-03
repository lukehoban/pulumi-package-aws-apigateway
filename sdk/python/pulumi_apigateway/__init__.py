# coding=utf-8
# *** WARNING: this file was generated by Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from . import _utilities
import typing
# Export this package's modules as members:
from ._enums import *
from .provider import *
from .rest_api import *
from ._inputs import *
_utilities.register(
    resource_modules="""
[
 {
  "pkg": "apigateway",
  "mod": "index",
  "fqn": "pulumi_apigateway",
  "classes": {
   "apigateway:index:RestAPI": "RestAPI"
  }
 }
]
""",
    resource_packages="""
[
 {
  "pkg": "apigateway",
  "token": "pulumi:providers:apigateway",
  "fqn": "pulumi_apigateway",
  "class": "Provider"
 }
]
"""
)
