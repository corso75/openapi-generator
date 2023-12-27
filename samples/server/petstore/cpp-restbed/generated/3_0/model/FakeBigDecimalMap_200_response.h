/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 7.0.0-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

/*
 * FakeBigDecimalMap_200_response.h
 *
 * 
 */

#ifndef FakeBigDecimalMap_200_response_H_
#define FakeBigDecimalMap_200_response_H_



#include <map>
#include <memory>
#include <vector>
#include <boost/property_tree/ptree.hpp>
#include "helpers.h"

namespace org {
namespace openapitools {
namespace server {
namespace model {

/// <summary>
/// 
/// </summary>
class  FakeBigDecimalMap_200_response 
{
public:
    FakeBigDecimalMap_200_response() = default;
    explicit FakeBigDecimalMap_200_response(boost::property_tree::ptree const& pt);
    virtual ~FakeBigDecimalMap_200_response() = default;

    FakeBigDecimalMap_200_response(const FakeBigDecimalMap_200_response& other) = default; // copy constructor
    FakeBigDecimalMap_200_response(FakeBigDecimalMap_200_response&& other) noexcept = default; // move constructor

    FakeBigDecimalMap_200_response& operator=(const FakeBigDecimalMap_200_response& other) = default; // copy assignment
    FakeBigDecimalMap_200_response& operator=(FakeBigDecimalMap_200_response&& other) noexcept = default; // move assignment

    std::string toJsonString(bool prettyJson = false) const;
    void fromJsonString(std::string const& jsonString);
    boost::property_tree::ptree toPropertyTree() const;
    void fromPropertyTree(boost::property_tree::ptree const& pt);


    /////////////////////////////////////////////
    /// FakeBigDecimalMap_200_response members

    /// <summary>
    /// 
    /// </summary>
    double getSomeId() const;
    void setSomeId(double value);

    /// <summary>
    /// 
    /// </summary>
    std::map<std::string, double> getSomeMap() const;
    void setSomeMap(std::map<std::string, double> value);

protected:
    double m_SomeId = 0.0;
    std::map<std::string, double> m_SomeMap;
};

std::vector<FakeBigDecimalMap_200_response> createFakeBigDecimalMap_200_responseVectorFromJsonString(const std::string& json);

template<>
inline boost::property_tree::ptree toPt<FakeBigDecimalMap_200_response>(const FakeBigDecimalMap_200_response& val) {
    return val.toPropertyTree();
}

template<>
inline FakeBigDecimalMap_200_response fromPt<FakeBigDecimalMap_200_response>(const boost::property_tree::ptree& pt) {
    FakeBigDecimalMap_200_response ret;
    ret.fromPropertyTree(pt);
    return ret;
}

}
}
}
}

#endif /* FakeBigDecimalMap_200_response_H_ */
