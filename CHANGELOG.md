# 更新说明

## V1.1.7(2019/07/15)

- 同步到官方文档最新接口内容。
- Asp.net core项目添加了新Api对象：电子面单及方舟天气API。

## V1.1.6(2019/05/29)

- 同步到官方文档最新接口内容。
- Asp.net core项目添加了新Api对象。

## V1.1.5(2019/05/12)

- 修复了请求类型默认值问题导致的出错问题。
- 修改部分API接口命名。
- AccessToken对于非授权接口，可不填写。
- 接口同步到官方文档。

## V1.1.4(2019/04/07)

- Console生成模型的程序更新，官方之前的api失效。
- 接口内容同步到官方文档最新接口。
- 请求类默认超时时间设置为10秒。

## V1.10(2019/03/19)

- 核心类库添加了对 `Net452` 框架的支持，方便非Net Core直接使用核心类库。
- 测试了图片上传功能。官方文档并没有明确图片上传的内容，只是说提交一个base64字符串，实际上你需要上传的内容应该类似下面:

  `data:image/png;base64,XXXXXX`

你需要在你的base64前面拼接上`data:image`相关信息，这样才能成功，否则会提示图片格式错误。

## V1.04(2019/03/12)

- 修复复杂请求模型，签名验证错误的问题。

## V1.02(2019/02/25)

- 同步更新到官方最新接口。

## V1.0 (2019/01/10)

- 添加完善新接口，同步到官方最新，如消息服务API。
- 完善所有请求和返回类，新增新接口所需类型。

## V0.2.0 (2018/11/12)

- 添加完善新接口，同步到官方最新。
- 完善所有请求和返回类，新增新接口所需类型。
- 处理某种情况下签名错误的问题。

## V0.1beta

- 添加了仓储 API。
- 添加 PddService 相关接口字段属性的中文注释。